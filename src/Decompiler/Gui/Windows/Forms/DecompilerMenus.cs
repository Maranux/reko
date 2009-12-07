/* 
 * Copyright (C) 1999-2009 John Källén.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */

// This file is automatically generated. DO NOT MAKE CHANGES TO IT, as they will be overwritten next time the 
// project compiles.
// This file was generated from Decompiler/GUI/decompiler-menus.xml using the Decompiler\Gui\Windows\Forms\decompiler-menus.xslt
// stylesheet. The intent of this file is to automatically generate the menus for the Windows Decompiler based on 
// the XML file. This saves developer effort when menu item verbs are added, removed, or changed.

using Decompiler.Gui;
using Decompiler.Gui.Windows.Controls;
using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Decompiler.Gui.Windows.Forms
{
    public class DecompilerMenus : MenuSystem   
    {
    	public readonly System.Windows.Forms.MainMenu MainMenu;	public readonly System.Windows.Forms.ContextMenu CtxMemoryControl;	public readonly System.Windows.Forms.ContextMenu CtxBrowser;	public readonly System.Windows.Forms.ToolStrip MainToolbar;
    
        public DecompilerMenus(ICommandTarget target) : base(target)
        {
			SortedList slMainMenu = CreatePriorityList();
			SortedList slFileMenu = CreatePriorityList();
			SortedList slEditMenu = CreatePriorityList();
			SortedList slViewMenu = CreatePriorityList();
			SortedList slActionMenu = CreatePriorityList();
			SortedList slHelpMenu = CreatePriorityList();
			SortedList slCtxMemoryControl = CreatePriorityList();
			SortedList slCtxBrowser = CreatePriorityList();
			SortedList slMainToolbar = CreatePriorityList();
			
			// Create groups
			
			SortedList slGrpMain = CreatePriorityList();
			slMainMenu.Add(0, slGrpMain);
			SortedList slGrpFile = CreatePriorityList();
			slFileMenu.Add(0, slGrpFile);
			SortedList slGrpFileMru = CreatePriorityList();
			slFileMenu.Add(0, slGrpFileMru);
			SortedList slGrpFileEnd = CreatePriorityList();
			slFileMenu.Add(1000, slGrpFileEnd);
			SortedList slGrpEdit = CreatePriorityList();
			slEditMenu.Add(0, slGrpEdit);
			SortedList slGrpViewScanned = CreatePriorityList();
			slViewMenu.Add(0, slGrpViewScanned);
			SortedList slGrpActions = CreatePriorityList();
			slActionMenu.Add(0, slGrpActions);
			SortedList slGrpActionsScanned = CreatePriorityList();
			slActionMenu.Add(0, slGrpActionsScanned);
			SortedList slGrpActionsRewritten = CreatePriorityList();
			slActionMenu.Add(0, slGrpActionsRewritten);
			SortedList slGrpHelp = CreatePriorityList();
			slHelpMenu.Add(0, slGrpHelp);
			SortedList slGrpMemoryControl = CreatePriorityList();
			slCtxMemoryControl.Add(0, slGrpMemoryControl);
			SortedList slGrpBrowser = CreatePriorityList();
			slCtxBrowser.Add(0, slGrpBrowser);
			SortedList slGrpToolbarFileOps = CreatePriorityList();
			slMainToolbar.Add(0, slGrpToolbarFileOps);
			SortedList slGrpToolbarActions = CreatePriorityList();
			slMainToolbar.Add(0, slGrpToolbarActions);
    
			// Create commands in containers.
            
            CommandMenuItem slFileOpen = new CommandMenuItem("_Open...", new Guid(CmdSets.Decompiler), CmdIds.FileOpen);
            slFileOpen.IsDynamic = false;
            slFileOpen.ImageIndex = 0;
            CommandMenuItem slFileOpenAs = new CommandMenuItem("Op_en As...", new Guid(CmdSets.Decompiler), CmdIds.FileOpenAs);
            slFileOpenAs.IsDynamic = false;
            
            CommandMenuItem slFileSave = new CommandMenuItem("_Save", new Guid(CmdSets.Decompiler), CmdIds.FileSave);
            slFileSave.IsDynamic = false;
            slFileSave.ImageIndex = 1;
            CommandMenuItem slFileMru = new CommandMenuItem("", new Guid(CmdSets.Decompiler), CmdIds.FileMru);
            slFileMru.IsDynamic = true;
            slGrpFileMru.Add(0, slFileMru);
            CommandMenuItem slFileExit = new CommandMenuItem("E_xit", new Guid(CmdSets.Decompiler), CmdIds.FileExit);
            slFileExit.IsDynamic = false;
            slGrpFileEnd.Add(0, slFileExit);
            CommandMenuItem slEditFind = new CommandMenuItem("_Find...", new Guid(CmdSets.Decompiler), CmdIds.EditFind);
            slEditFind.IsDynamic = false;
            slGrpEdit.Add(0, slEditFind);
            CommandMenuItem slViewGoToAddress = new CommandMenuItem("_Go to Address...", new Guid(CmdSets.Decompiler), CmdIds.ViewGoToAddress);
            slViewGoToAddress.IsDynamic = false;
            slGrpViewScanned.Add(0, slViewGoToAddress);
            CommandMenuItem slViewShowAllFragments = new CommandMenuItem("Show _all fragments", new Guid(CmdSets.Decompiler), CmdIds.ViewShowAllFragments);
            slViewShowAllFragments.IsDynamic = false;
            slGrpViewScanned.Add(0, slViewShowAllFragments);
            CommandMenuItem slViewShowUnscanned = new CommandMenuItem("Show _unscanned fragments", new Guid(CmdSets.Decompiler), CmdIds.ViewShowUnscanned);
            slViewShowUnscanned.IsDynamic = false;
            slGrpViewScanned.Add(0, slViewShowUnscanned);
            CommandMenuItem slViewFindFragments = new CommandMenuItem("_Find fragments...", new Guid(CmdSets.Decompiler), CmdIds.ViewFindFragments);
            slViewFindFragments.IsDynamic = false;
            slGrpViewScanned.Add(0, slViewFindFragments);
            CommandMenuItem slActionNextPhase = new CommandMenuItem("_Next Phase", new Guid(CmdSets.Decompiler), CmdIds.ActionNextPhase);
            slActionNextPhase.IsDynamic = false;
            slGrpActions.Add(0, slActionNextPhase);
            CommandMenuItem slActionFinishDecompilation = new CommandMenuItem("_Finish Decompilation", new Guid(CmdSets.Decompiler), CmdIds.ActionFinishDecompilation);
            slActionFinishDecompilation.IsDynamic = false;
            slGrpActions.Add(0, slActionFinishDecompilation);
            CommandMenuItem slActionMarkProcedure = new CommandMenuItem("Mark _Procedure Entry", new Guid(CmdSets.Decompiler), CmdIds.ActionMarkProcedure);
            slActionMarkProcedure.IsDynamic = false;
            
            CommandMenuItem slActionEditSignature = new CommandMenuItem("Edit _Signature...", new Guid(CmdSets.Decompiler), CmdIds.ActionEditSignature);
            slActionEditSignature.IsDynamic = false;
            
            CommandMenuItem slHelpAbout = new CommandMenuItem("_About Decompiler...", new Guid(CmdSets.Decompiler), CmdIds.HelpAbout);
            slHelpAbout.IsDynamic = false;
            slGrpHelp.Add(0, slHelpAbout);
			
			// Create submenus
			
            CommandMenuItem miFileMenu = new CommandMenuItem("_File");
            slGrpMain.Add(0, miFileMenu);
            CommandMenuItem miEditMenu = new CommandMenuItem("_Edit");
            slGrpMain.Add(0, miEditMenu);
            CommandMenuItem miViewMenu = new CommandMenuItem("_View");
            slGrpMain.Add(0, miViewMenu);
            CommandMenuItem miActionMenu = new CommandMenuItem("_Actions");
            slGrpMain.Add(0, miActionMenu);
            CommandMenuItem miHelpMenu = new CommandMenuItem("_Help");
            slGrpMain.Add(0, miHelpMenu);
    
			// Place commands.
			
			slGrpFile.Add(0, slFileOpen);
			slGrpFile.Add(0, slFileOpenAs);
			slGrpFile.Add(0, slFileSave);
			slGrpToolbarFileOps.Add(0, slFileOpen);
			slGrpToolbarFileOps.Add(0, slFileSave);
			slGrpToolbarActions.Add(0, slActionNextPhase);
			slGrpToolbarActions.Add(0, slActionFinishDecompilation);
			slGrpActionsScanned.Add(0, slActionMarkProcedure);
			slGrpMemoryControl.Add(0, slViewGoToAddress);
			slGrpMemoryControl.Add(0, slActionMarkProcedure);
			slGrpBrowser.Add(0, slActionEditSignature);
			slGrpActionsRewritten.Add(0, slActionEditSignature);
			this.MainMenu = new System.Windows.Forms.MainMenu();
			BuildMenu(slMainMenu, MainMenu.MenuItems);
  
			BuildMenu(slFileMenu, miFileMenu.MenuItems);
			
			BuildMenu(slEditMenu, miEditMenu.MenuItems);
			
			BuildMenu(slViewMenu, miViewMenu.MenuItems);
			
			BuildMenu(slActionMenu, miActionMenu.MenuItems);
			
			BuildMenu(slHelpMenu, miHelpMenu.MenuItems);
			
			this.CtxMemoryControl = new System.Windows.Forms.ContextMenu();
			BuildMenu(slCtxMemoryControl, CtxMemoryControl.MenuItems);
  
			this.CtxBrowser = new System.Windows.Forms.ContextMenu();
			BuildMenu(slCtxBrowser, CtxBrowser.MenuItems);
  
			this.MainToolbar = new System.Windows.Forms.ToolStrip();
			BuildMenu(slMainToolbar, MainToolbar.Items);
  
		}
		
		public override Menu GetMenu(int menuId)
		{	
			switch (menuId)
			{
				case MenuIds.MainMenu: return this.MainMenu;
			}
			throw new ArgumentException(string.Format("There is no menu with id {0}.", menuId));
			
		}
		
		public override ContextMenu GetContextMenu(int menuId)
		{
			
			switch (menuId)
			{
				case MenuIds.CtxMemoryControl: return this.CtxMemoryControl;
				case MenuIds.CtxBrowser: return this.CtxBrowser;
			}
			throw new ArgumentException(string.Format("There is no context menu with id {0}.", menuId));
		}
    
    public override ToolStrip GetToolStrip(int menuId)
    {
      
      switch (menuId)
      {
        case MenuIds.MainToolbar: return this.MainToolbar;
      }
      throw new ArgumentException(string.Format("There is no tool strip with id {0}.", menuId));
    }

    }
    }
  