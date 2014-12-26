﻿#region Copyright © 2014 Ricardo Amaral

/*
 * Use of this source code is governed by an MIT-style license that can be found in the LICENSE file.
 */

#endregion

using CefSharp;

namespace SlackUI {

    internal class BrowserMenuHandler : IMenuHandler {

        #region Public Methods

        /*
         * Handler for the browser on before context menu event.
         */
        public bool OnBeforeContextMenu(IWebBrowser browser, IContextMenuParams parameters) {
            // Disable the context menu
            return false;
        }

        #endregion

    }

}
