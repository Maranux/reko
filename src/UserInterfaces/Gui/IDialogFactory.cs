#region License
/* 
* Copyright (C) 1999-2017 John Källén.
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
#endregion

using Reko.Core;
using Reko.Gui.Forms;
using System;
using Reko.Gui.Windows.Forms;
using Reko.Core.Machine;

namespace Reko.Gui
{
    public interface IDialogFactory
    {
        IAssembleFileDialog CreateAssembleFileDialog();
        IAssumedRegisterValuesDialog CreateAssumedRegisterValuesDialog(IProcessorArchitecture arch);
        IAddressPromptDialog CreateAddressPromptDialog();
        ICallSiteDialog CreateCallSiteDialog(Program program, UserCallData ucd);
        IFindStringsDialog CreateFindStringDialog();
        IMainForm CreateMainForm();
        IOpenAsDialog CreateOpenAsDialog();
        IProcedureDialog CreateProcedureDialog(Program program, Core.Serialization.Procedure_v1 sProc);
        IProgramPropertiesDialog CreateProgramPropertiesDialog(Program program);
        IResourceEditor CreateResourceEditor();
        ISearchDialog CreateSearchDialog();
        IUserPreferencesDialog CreateUserPreferencesDialog();
        IWorkerDialog CreateWorkerDialog();
        ITextEncodingDialog CreateTextEncodingDialog();
        IDeclarationForm CreateDeclarationForm();
        IJumpTableDialog CreateJumpTableDialog(Program program, MachineInstruction instrIndirectJmp, Address addrVector, int stride);
    }
}