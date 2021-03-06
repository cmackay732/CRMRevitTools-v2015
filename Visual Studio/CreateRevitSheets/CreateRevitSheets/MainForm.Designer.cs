﻿//    Copyright(C) 2018  Christopher Ryan Mackay

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<https://www.gnu.org/licenses/>.

namespace CreateRevitSheets
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTitleblocks = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSheetList = new System.Windows.Forms.Label();
            this.lblTitleblocks = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstAvailableViews = new System.Windows.Forms.ListBox();
            this.lblViews = new System.Windows.Forms.Label();
            this.btnAddView = new System.Windows.Forms.Button();
            this.btnRemoveView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSheetToCreate = new System.Windows.Forms.DataGridView();
            this.Sheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditSheet = new System.Windows.Forms.Button();
            this.btnRemoveSheet = new System.Windows.Forms.Button();
            this.cbViewTypes = new System.Windows.Forms.ComboBox();
            this.btnAddSheet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheetToCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTitleblocks
            // 
            this.cbTitleblocks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbTitleblocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitleblocks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTitleblocks.FormattingEnabled = true;
            this.cbTitleblocks.Location = new System.Drawing.Point(9, 75);
            this.cbTitleblocks.Name = "cbTitleblocks";
            this.cbTitleblocks.Size = new System.Drawing.Size(558, 21);
            this.cbTitleblocks.TabIndex = 4;
            this.cbTitleblocks.SelectedIndexChanged += new System.EventHandler(this.cbTitleblocks_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFilename.Enabled = false;
            this.txtFilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilename.Location = new System.Drawing.Point(9, 30);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(558, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(516, 464);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(597, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Location = new System.Drawing.Point(573, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSheetList
            // 
            this.lblSheetList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSheetList.AutoSize = true;
            this.lblSheetList.BackColor = System.Drawing.Color.Transparent;
            this.lblSheetList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSheetList.Location = new System.Drawing.Point(9, 12);
            this.lblSheetList.Name = "lblSheetList";
            this.lblSheetList.Size = new System.Drawing.Size(66, 13);
            this.lblSheetList.TabIndex = 0;
            this.lblSheetList.Text = "Sheet list file";
            // 
            // lblTitleblocks
            // 
            this.lblTitleblocks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitleblocks.AutoSize = true;
            this.lblTitleblocks.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleblocks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleblocks.Location = new System.Drawing.Point(9, 57);
            this.lblTitleblocks.Name = "lblTitleblocks";
            this.lblTitleblocks.Size = new System.Drawing.Size(91, 13);
            this.lblTitleblocks.TabIndex = 3;
            this.lblTitleblocks.Text = "Select a titleblock";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoad.Location = new System.Drawing.Point(573, 74);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstAvailableViews
            // 
            this.lstAvailableViews.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstAvailableViews.FormattingEnabled = true;
            this.lstAvailableViews.HorizontalScrollbar = true;
            this.lstAvailableViews.Location = new System.Drawing.Point(9, 135);
            this.lstAvailableViews.Name = "lstAvailableViews";
            this.lstAvailableViews.ScrollAlwaysVisible = true;
            this.lstAvailableViews.Size = new System.Drawing.Size(166, 264);
            this.lstAvailableViews.TabIndex = 7;
            // 
            // lblViews
            // 
            this.lblViews.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblViews.AutoSize = true;
            this.lblViews.BackColor = System.Drawing.Color.Transparent;
            this.lblViews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblViews.Location = new System.Drawing.Point(9, 119);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(81, 13);
            this.lblViews.TabIndex = 6;
            this.lblViews.Text = "Available Views";
            // 
            // btnAddView
            // 
            this.btnAddView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddView.Location = new System.Drawing.Point(182, 246);
            this.btnAddView.Name = "btnAddView";
            this.btnAddView.Size = new System.Drawing.Size(123, 23);
            this.btnAddView.TabIndex = 12;
            this.btnAddView.Text = "Add View -->";
            this.btnAddView.UseVisualStyleBackColor = true;
            this.btnAddView.Click += new System.EventHandler(this.btnAddView_Click);
            // 
            // btnRemoveView
            // 
            this.btnRemoveView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveView.Location = new System.Drawing.Point(182, 275);
            this.btnRemoveView.Name = "btnRemoveView";
            this.btnRemoveView.Size = new System.Drawing.Size(123, 23);
            this.btnRemoveView.TabIndex = 13;
            this.btnRemoveView.Text = "<-- Remove View";
            this.btnRemoveView.UseVisualStyleBackColor = true;
            this.btnRemoveView.Click += new System.EventHandler(this.btnRemoveView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvSheetToCreate);
            this.panel1.Controls.Add(this.btnEditSheet);
            this.panel1.Controls.Add(this.btnRemoveSheet);
            this.panel1.Controls.Add(this.cbViewTypes);
            this.panel1.Controls.Add(this.btnAddSheet);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnRemoveView);
            this.panel1.Controls.Add(this.lblTitleblocks);
            this.panel1.Controls.Add(this.lblSheetList);
            this.panel1.Controls.Add(this.btnAddView);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.lstAvailableViews);
            this.panel1.Controls.Add(this.txtFilename);
            this.panel1.Controls.Add(this.cbTitleblocks);
            this.panel1.Controls.Add(this.lblViews);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 440);
            this.panel1.TabIndex = 0;
            // 
            // dgvSheetToCreate
            // 
            this.dgvSheetToCreate.AllowUserToAddRows = false;
            this.dgvSheetToCreate.AllowUserToDeleteRows = false;
            this.dgvSheetToCreate.AllowUserToOrderColumns = true;
            this.dgvSheetToCreate.AllowUserToResizeColumns = false;
            this.dgvSheetToCreate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvSheetToCreate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSheetToCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvSheetToCreate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSheetToCreate.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSheetToCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSheetToCreate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSheetToCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSheetToCreate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sheet,
            this.View});
            this.dgvSheetToCreate.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSheetToCreate.Location = new System.Drawing.Point(313, 114);
            this.dgvSheetToCreate.MultiSelect = false;
            this.dgvSheetToCreate.Name = "dgvSheetToCreate";
            this.dgvSheetToCreate.ReadOnly = true;
            this.dgvSheetToCreate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSheetToCreate.RowHeadersVisible = false;
            this.dgvSheetToCreate.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvSheetToCreate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSheetToCreate.Size = new System.Drawing.Size(335, 314);
            this.dgvSheetToCreate.TabIndex = 16;
            this.dgvSheetToCreate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvSheetToCreate_MouseUp_1);
            // 
            // Sheet
            // 
            this.Sheet.HeaderText = "Sheet";
            this.Sheet.Name = "Sheet";
            this.Sheet.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            // 
            // btnEditSheet
            // 
            this.btnEditSheet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditSheet.Location = new System.Drawing.Point(182, 164);
            this.btnEditSheet.Name = "btnEditSheet";
            this.btnEditSheet.Size = new System.Drawing.Size(123, 23);
            this.btnEditSheet.TabIndex = 10;
            this.btnEditSheet.Text = "Edit Sheet";
            this.btnEditSheet.UseVisualStyleBackColor = true;
            this.btnEditSheet.Click += new System.EventHandler(this.btnEditSheet_Click);
            // 
            // btnRemoveSheet
            // 
            this.btnRemoveSheet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveSheet.Location = new System.Drawing.Point(182, 193);
            this.btnRemoveSheet.Name = "btnRemoveSheet";
            this.btnRemoveSheet.Size = new System.Drawing.Size(123, 23);
            this.btnRemoveSheet.TabIndex = 11;
            this.btnRemoveSheet.Text = "Remove Sheet";
            this.btnRemoveSheet.UseVisualStyleBackColor = true;
            this.btnRemoveSheet.Click += new System.EventHandler(this.btnRemoveSheet_Click);
            // 
            // cbViewTypes
            // 
            this.cbViewTypes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbViewTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewTypes.FormattingEnabled = true;
            this.cbViewTypes.Items.AddRange(new object[] {
            "Floor Plans",
            "Ceiling Plans",
            "Drafting Views",
            "Legends",
            "Sections",
            "Elevations"});
            this.cbViewTypes.Location = new System.Drawing.Point(9, 407);
            this.cbViewTypes.Name = "cbViewTypes";
            this.cbViewTypes.Size = new System.Drawing.Size(166, 21);
            this.cbViewTypes.TabIndex = 8;
            this.cbViewTypes.SelectedIndexChanged += new System.EventHandler(this.cbViews_SelectedIndexChanged);
            // 
            // btnAddSheet
            // 
            this.btnAddSheet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddSheet.Location = new System.Drawing.Point(182, 135);
            this.btnAddSheet.Name = "btnAddSheet";
            this.btnAddSheet.Size = new System.Drawing.Size(123, 23);
            this.btnAddSheet.TabIndex = 9;
            this.btnAddSheet.Text = "Add Sheet";
            this.btnAddSheet.UseVisualStyleBackColor = true;
            this.btnAddSheet.Click += new System.EventHandler(this.btnAddSheet_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Sheets";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheetToCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbTitleblocks;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblSheetList;
        private System.Windows.Forms.Label lblTitleblocks;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.Button btnAddView;
        private System.Windows.Forms.Button btnRemoveView;
        public System.Windows.Forms.ListBox lstAvailableViews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbViewTypes;
        private System.Windows.Forms.Button btnRemoveSheet;
        private System.Windows.Forms.Button btnAddSheet;
        public System.Windows.Forms.Button btnEditSheet;
        private System.Windows.Forms.DataGridView dgvSheetToCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn View;
    }
}