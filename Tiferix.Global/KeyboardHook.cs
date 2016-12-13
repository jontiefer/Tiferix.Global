/* Copyright © 2016-2017 Jonathan Tiefer - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the GNU Lesser General Public License (LGPL)
 *
 * You should have received a copy of the LGPL license with
 * this file.
 *
 * /

/*  This file is part of Tiferix.Global
*
*   Tiferix.Global is free software: you can redistribute it and/or modify
*   it under the terms of the GNU Lesser General Public License as published by
*   the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.
*
*   Tiferix.Global is distributed in the hope that it will be useful,
*   but WITHOUT ANY WARRANTY; without even the implied warranty of
*   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*   GNU Lesser General Public License for more details.
*
*  You should have received a copy of the GNU Lesser General Public License
*   along with Tiferix.Global.  If not, see <http://www.gnu.org/licenses/>.
*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiferix.Global
{
    /// <summary>
    /// The KeyboardHook class will be used to capture hot key events of the operating system from .Net and process the hot keys from the .Net
    /// application.
    /// </summary>
    public sealed class KeyboardHook : IDisposable
    {
        #region API Function Declarations

        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        #endregion

        #region Events

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        #endregion

        #region Member Variables        

        private int m_iCurrentId = 0;

        private List<int> m_lstHotKeyIds = new List<int>();

        #endregion

        #region Member Object Variables

        private Window m_Window = new Window();

        #endregion

        #region Window Class 

        /// <summary>
        /// Represents the window that is used internally to get the messages.
        /// </summary>
        private class Window : NativeWindow, IDisposable
        {
            #region Constants

            private static int WM_HOTKEY = 0x0312;

            #endregion

            #region Events

            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            #endregion


            #region Construction/Initialization

            /// <summary>
            /// Constructor
            /// </summary>
            public Window()
            {
                // create the handle for the window.
                this.CreateHandle(new CreateParams());
            }

            #endregion

            #region Window Procedure/Window Message Functions, Event Handlers

            /// <summary>
            /// Overridden to get the notifications.
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                try
                {
                    base.WndProc(ref m);

                    // check if we got a hot key pressed.
                    if (m.Msg == WM_HOTKEY)
                    {
                        // get the keys.
                        Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                        ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                        // invoke the event to notify the parent.
                        if (KeyPressed != null)
                            KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                    }
                }
                catch (Exception err)
                {
                    ErrorHandler.ShowErrorMessage(err, "Error in WndProc funciton of KeyboardHook.Window class.");
                }
            }

            #endregion            

            #region IDisposable Members

            /// <summary>
            /// Dispose all resources used by Window class.
            /// </summary>
            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Constructor
        /// </summary>
        public KeyboardHook()
        {
            try
            {
                // register the event of the inner native window.
                m_Window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
                {
                    if (KeyPressed != null)
                        KeyPressed(this, args);
                };
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Constructor function of KeyboardHook class.");
            }
        }

        #endregion

        #region Hot Key Registration/Unregistration Functions

        /// <summary>
        /// Registers a hot key in the system.  Returns a HotKeyId unique to the specific native window.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        public int RegisterHotKey(ModifierKeys modifier, Keys key)
        {
            try
            {
                //Increments current HotKeyId and adds hot key Id to hot key Id list.
                m_iCurrentId++;
                m_lstHotKeyIds.Add(m_iCurrentId);

                // register the hot key.
                if (!RegisterHotKey(m_Window.Handle, m_iCurrentId, (uint)modifier, (uint)key))
                {
                    Debug.WriteLine("Hot Key Already Registered.");
                }//end if

                return m_iCurrentId;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in RegisterHotKey function of KeyboardHook class.");
                return -1;
            }
        }

        /// <summary>
        /// Unregisters a hot key previous registered on the system.
        /// </summary>
        /// <param name="iHotKeyId">Unique HotKeyId associated with the hot key to unregister.</param>
        public void UnregisterHotKey(int iHotKeyId)
        {
            try
            {
                if (m_lstHotKeyIds.Contains(iHotKeyId))
                    m_lstHotKeyIds.Remove(iHotKeyId);

                //Un-register the hot key.                
                if (!UnregisterHotKey(m_Window.Handle, iHotKeyId))
                    throw new InvalidOperationException("Couldn’t unregister the hot key.");
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in RegisterHotKey function of KeyboardHook class.");
            }
        }

        /// <summary>
        /// Unregisters all registered hot keys for the specific window.
        /// </summary>
        public void UnregisterWinHotKeys()
        {
            try
            {
                //Unregister all the registered hot keys.
                foreach (int iHotKeyId in m_lstHotKeyIds)
                {
                    UnregisterHotKey(m_Window.Handle, iHotKeyId);
                }//next iHotKeyId

                m_iCurrentId = 0;
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in UnregisterWinHotKeys function of KeyboardHook class.");
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Disposes all resources used by the KeyboardHook class.
        /// </summary>
        public void Dispose()
        {
            try
            {
                UnregisterWinHotKeys();

                // dispose the inner native window.
                m_Window.Dispose();
            }
            catch (Exception err)
            {
                ErrorHandler.ShowErrorMessage(err, "Error in Dispose function of KeyboardHook class.");
            }
        }

        #endregion
    }

    /// <summary>
    /// Event Args for the event that is fired after the hot key has been pressed.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
        private ModifierKeys m_Modifier;
        private Keys m_Key;

        /// <summary>
        /// Event Args for the event that is fired after the hot key has been pressed.
        /// </summary>
        /// <param name="modifier"></param>
        /// <param name="key"></param>
        internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
        {            
            m_Modifier = modifier;
            m_Key = key;
        }

        /// <summary>
        /// Modifier keys used in combination with a specific key value for a hot key.
        /// </summary>
        public ModifierKeys Modifier
        {
            get { return m_Modifier; }
        }

        /// <summary>
        /// Key value used for the hot key.
        /// </summary>
        public Keys Key
        {
            get { return m_Key; }
        }
    }

    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierKeys : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}
