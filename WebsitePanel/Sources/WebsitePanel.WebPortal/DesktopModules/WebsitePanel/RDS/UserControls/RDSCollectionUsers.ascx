<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RDSCollectionUsers.ascx.cs" Inherits="WebsitePanel.Portal.RDS.UserControls.RDSCollectionUsers" %>
<%@ Register Src="../../UserControls/PopupHeader.ascx" TagName="PopupHeader" TagPrefix="wsp" %>

<asp:UpdatePanel ID="UsersUpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
    <ContentTemplate>
	<div class="FormButtonsBarClean">
		<asp:Button ID="btnAdd" runat="server" Text="Add..." CssClass="Button1"  OnClick="btnAdd_Click" meta:resourcekey="btnAdd"  />
		<asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="Button1" OnClick="btnDelete_Click" OnClientClick="ShowProgressDialog('Checking users ...');return true;" meta:resourcekey="btnDelete"/>
	</div>
	<asp:GridView ID="gvUsers" runat="server" meta:resourcekey="gvUsers" AutoGenerateColumns="False"
		Width="600px" CssSelectorClass="NormalGridView" OnRowCommand="gvUsers_RowCommand"
		DataKeyNames="AccountName">
		<Columns>
			<asp:TemplateField>
				<HeaderTemplate>
					<asp:CheckBox ID="chkSelectAll" runat="server" onclick="javascript:SelectAllCheckboxes(this);" />
				</HeaderTemplate>
				<ItemTemplate>
					<asp:CheckBox ID="chkSelect" runat="server" />
				</ItemTemplate>
				<ItemStyle Width="10px" />
			</asp:TemplateField>
			<asp:TemplateField meta:resourcekey="gvUsersAccount" HeaderText="gvUsersAccount">
				<ItemStyle Width="80%" Wrap="false" HorizontalAlign="Left">
				</ItemStyle>
				<ItemTemplate>                    
                    <asp:Literal ID="litAccount" runat="server" Text='<%# Eval("DisplayName") %>'></asp:Literal>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# GetThemedImage("Exchange/admin_16.png") %>' Visible='<%# Convert.ToBoolean(Eval("IsVIP")) %>' ImageAlign="AbsMiddle" />
                    <asp:HiddenField ID="hdnSamAccountName" runat="server" Value='<%# Eval("SamAccountName") %>' />
				</ItemTemplate>
			</asp:TemplateField>
            <asp:TemplateField meta:resourcekey="gvSetupInstructions">
                <ItemStyle Width="20%" HorizontalAlign="right"></ItemStyle>
                <ItemTemplate>
                    <asp:LinkButton ID="lbSetupInstructions" CommandName="SetupInstructions" CommandArgument='<%# Eval("AccountId")%>' runat="server"
                        Text="Setup Instructions" OnClientClick="ShowProgressDialog('Loading ...');return true;"/>
                </ItemTemplate>
            </asp:TemplateField>
		</Columns>
	</asp:GridView>
    <br />


<asp:Panel ID="AddAccountsPanel" runat="server" CssClass="Popup" style="display:none">
	<table class="Popup-Header" cellpadding="0" cellspacing="0">
		<tr>
			<td class="Popup-HeaderLeft"></td>
			<td class="Popup-HeaderTitle">
				<asp:Localize ID="headerAddAccounts" runat="server" meta:resourcekey="headerAddAccounts"></asp:Localize>
			</td>
			<td class="Popup-HeaderRight"></td>
		</tr>
	</table>
	<div class="Popup-Content">
		<div class="Popup-Body">
			<br />
<asp:UpdatePanel ID="AddAccountsUpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
    <ContentTemplate>
	            
                <div class="FormButtonsBarClean">
                    <div class="FormButtonsBarCleanRight">
                        <asp:Panel ID="SearchPanel" runat="server" DefaultButton="cmdSearch">
                            <asp:DropDownList ID="ddlSearchColumn" runat="server" CssClass="NormalTextBox">
                                <asp:ListItem Value="DisplayName" meta:resourcekey="ddlSearchColumnDisplayName">DisplayName</asp:ListItem>
                                <asp:ListItem Value="PrimaryEmailAddress" meta:resourcekey="ddlSearchColumnEmail">Email</asp:ListItem>
                            </asp:DropDownList><asp:TextBox ID="txtSearchValue" runat="server" CssClass="NormalTextBox" Width="100"></asp:TextBox><asp:ImageButton ID="cmdSearch" Runat="server" meta:resourcekey="cmdSearch" SkinID="SearchButton"
	                            CausesValidation="false" OnClick="cmdSearch_Click"/>
                        </asp:Panel>
                    </div>
                </div>
                <div class="Popup-Scroll">
					<asp:GridView ID="gvPopupAccounts" runat="server" meta:resourcekey="gvPopupAccounts" AutoGenerateColumns="False"
						Width="100%" CssSelectorClass="NormalGridView"
						DataKeyNames="AccountName">
						<Columns>
							<asp:TemplateField>
								<HeaderTemplate>
									<asp:CheckBox ID="chkSelectAll" runat="server" onclick="javascript:SelectAllCheckboxes(this);" />
								</HeaderTemplate>
								<ItemTemplate>
									<asp:CheckBox ID="chkSelect" runat="server" />
									<asp:Literal ID="litAccountType" runat="server" Visible="false" Text='<%# Eval("AccountType") %>'></asp:Literal>
								</ItemTemplate>
								<ItemStyle Width="10px" />
							</asp:TemplateField>
							<asp:TemplateField meta:resourcekey="gvAccountsDisplayName">
								<ItemStyle Width="50%" HorizontalAlign="Left"></ItemStyle>
								<ItemTemplate>
									<asp:Image ID="imgAccount" runat="server" ImageUrl='<%# GetAccountImage((int)Eval("AccountType")) %>' ImageAlign="AbsMiddle" />
									<asp:Literal ID="litDisplayName" runat="server" Text='<%# Eval("DisplayName") %>'></asp:Literal>
                                    <asp:HiddenField ID="hdnSamName" runat="server" Value='<%# Eval("SamAccountName") %>' />
                                    <asp:HiddenField ID="hdnLocalAdmin" runat="server" Value='<%# Eval("IsVIP").ToString() %>' />
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField meta:resourcekey="gvAccountsEmail">
								<ItemStyle Width="50%" HorizontalAlign="Left"></ItemStyle>
								<ItemTemplate>
									<asp:Literal ID="litPrimaryEmailAddress" runat="server" Text='<%# Eval("PrimaryEmailAddress") %>'></asp:Literal>
								</ItemTemplate>
							</asp:TemplateField>                            
						</Columns>
					</asp:GridView>
				</div>
	</ContentTemplate>
</asp:UpdatePanel>
			<br />
		</div>
		
		<div class="FormFooter">
			<asp:Button ID="btnAddSelected" runat="server" CssClass="Button1" meta:resourcekey="btnAddSelected" Text="Add Accounts" OnClick="btnAddSelected_Click" />
			<asp:Button ID="btnCancelAdd" runat="server" CssClass="Button1" meta:resourcekey="btnCancel" Text="Cancel" CausesValidation="false" />
		</div>
	</div>
</asp:Panel>

        <asp:Panel ID="DeleteWarningPanel" runat="server" CssClass="Popup" style="display:none">
            <table class="Popup-Header" cellpadding="0" cellspacing="0">
                <tr>
                    <td class="Popup-HeaderLeft"/>
                    <td class="Popup-HeaderTitle">
                        <asp:Localize ID="lcDeleteWarningHeader" runat="server" meta:resourcekey="headerDeleteWarning"></asp:Localize>
                    </td>
                    <td class="Popup-HeaderRight"/>
                </tr>
            </table>
            <div class="Popup-Content">
                <div class="Popup-Body">
                    <br />
                    <asp:UpdatePanel ID="deleteWarningUpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
                        <ContentTemplate>
                            <div class="Popup-Scroll" style="height:auto;">                                                        
                                <asp:Panel runat="server" ID="panelDeleteWarning">
                                    <asp:Localize runat="server" ID="locDeleteWarning" Text="Unable to remove the following user(s) since they are local admins or<br/>they were granted access to remote applications" />
                                    <br/>
                                    <asp:Literal runat="server" ID="ltUsers" Text="" />
                                </asp:Panel>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                </div>
                <div class="FormFooter">                
                    <asp:Button ID="btnCancelDeleteWarning" runat="server" CssClass="Button1" meta:resourcekey="btnCancelDeleteWarning" Text="Cancel" CausesValidation="false" />
                </div>
            </div>
        </asp:Panel>
        <asp:Button ID="btnDeleteWarningFake" runat="server" style="display:none;" />
        <ajaxToolkit:ModalPopupExtender ID="DeleteWarningModal" runat="server" TargetControlID="btnDeleteWarningFake" PopupControlID="DeleteWarningPanel" 
            BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btnCancelDeleteWarning"/>

<asp:Button ID="btnAddAccountsFake" runat="server" style="display:none;" />
<ajaxToolkit:ModalPopupExtender ID="AddAccountsModal" runat="server"
	TargetControlID="btnAddAccountsFake" PopupControlID="AddAccountsPanel"
	BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btnCancelAdd" />

	</ContentTemplate>
</asp:UpdatePanel>