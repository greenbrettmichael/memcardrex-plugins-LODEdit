﻿//The Legend of Dragoon save editor
//Shendo 2010 - 2013

using System;
using System.Collections.Generic;
using System.Text;
using LODEdit;
using System.Windows.Forms;

//Plugin must be in the "rexPluginSystem" namespace in order to be recognised by MemcardRex.
namespace rexPluginSystem
{
    //All plugins should incorporate this interface in order to comunicate with MemcardRex 1.6+.
    public interface rexPluginInterfaceV2
    {
        string getPluginName();
        string getPluginAuthor();
        string getPluginSupportedGames();
        string[] getSupportedProductCodes();
        byte[] editSaveData(byte[] gameSaveData, string saveProductCode);
        void showAboutDialog();
        void showConfigDialog();
    }

    public class rexPlugin : rexPluginInterfaceV2
    {
        private const string pluginName = "LODEdit";
        private const string pluginVersion = "0.1";
        private const string pluginAuthor = "greenbrettmichael";
        private const string pluginSupportedGames = "The Legend of Dragoon";

        //Return Plugin's name (name + plugin version is recommended)
        public string getPluginName()
        {
            return pluginName + " " + pluginVersion;
        }

        //Return Author's name.
        public string getPluginAuthor()
        {
            return pluginAuthor;
        }

        //Return a list of games supported by the plugin
        public string getPluginSupportedGames()
        {
            return pluginSupportedGames;
        }

        //Return a string array of product codes compatible with this plugin.
        //In order to make a product-code-independent-plugin one member should be "*.*".
        public string[] getSupportedProductCodes()
        {
            //All versions of The Legend of Dragoon are supported
            return new string[] { "SCUS-94491", "SCESP03047", "SCES-03047" };
        }

        //A data to process. Edited save data should be returned.
        //Array size depends on the number of slots that specific save takes (Save header (128 bytes) + Number of slots * 8192 bytes).
        public byte[] editSaveData(byte[] gameSaveData, string saveProductCode)
        {
            //Make a new instance of the main window
            mainWindow mainDialog = new mainWindow();

            //Initialize main dialog
            return mainDialog.initDialog(pluginName + " " + pluginVersion, gameSaveData);
        }

        public void showAboutDialog()
        {
            new AboutWindow().initDialog(pluginName, pluginVersion, pluginSupportedGames, "Author: " + pluginAuthor, "Supported product codes:\nSCUS-94491 - NTSC U/C");
        }

        public void showConfigDialog()
        {
            MessageBox.Show("This plugin has no options you can configure.", pluginName + " " + pluginVersion);
        }
    }
}
