﻿namespace mRemoteNG.UI.Forms
{
    partial class UnhandledExceptionWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelExceptionCaught = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxStackTrace = new System.Windows.Forms.TextBox();
            this.labelStackTraceHeader = new System.Windows.Forms.Label();
            this.labelExceptionMessageHeader = new System.Windows.Forms.Label();
            this.textBoxExceptionMessage = new System.Windows.Forms.TextBox();
            this.buttonCopyAll = new System.Windows.Forms.Button();
            this.labelExceptionIsFatalHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.labelExceptionCaught, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStackTrace, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelStackTraceHeader, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelExceptionMessageHeader, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExceptionMessage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCopyAll, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelExceptionIsFatalHeader, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelExceptionCaught
            // 
            this.labelExceptionCaught.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelExceptionCaught, 2);
            this.labelExceptionCaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExceptionCaught.Location = new System.Drawing.Point(33, 0);
            this.labelExceptionCaught.Name = "labelExceptionCaught";
            this.labelExceptionCaught.Size = new System.Drawing.Size(311, 20);
            this.labelExceptionCaught.TabIndex = 3;
            this.labelExceptionCaught.Text = "An unhandled exception has occurred";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(427, 284);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(74, 24);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxStackTrace
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxStackTrace, 2);
            this.textBoxStackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStackTrace.Location = new System.Drawing.Point(33, 128);
            this.textBoxStackTrace.Multiline = true;
            this.textBoxStackTrace.Name = "textBoxStackTrace";
            this.textBoxStackTrace.ReadOnly = true;
            this.textBoxStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStackTrace.Size = new System.Drawing.Size(468, 150);
            this.textBoxStackTrace.TabIndex = 0;
            // 
            // labelStackTraceHeader
            // 
            this.labelStackTraceHeader.AutoSize = true;
            this.labelStackTraceHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStackTraceHeader.Location = new System.Drawing.Point(33, 112);
            this.labelStackTraceHeader.Name = "labelStackTraceHeader";
            this.labelStackTraceHeader.Size = new System.Drawing.Size(388, 13);
            this.labelStackTraceHeader.TabIndex = 4;
            this.labelStackTraceHeader.Text = "Stack trace";
            // 
            // labelExceptionMessageHeader
            // 
            this.labelExceptionMessageHeader.AutoSize = true;
            this.labelExceptionMessageHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelExceptionMessageHeader.Location = new System.Drawing.Point(33, 53);
            this.labelExceptionMessageHeader.Name = "labelExceptionMessageHeader";
            this.labelExceptionMessageHeader.Size = new System.Drawing.Size(388, 13);
            this.labelExceptionMessageHeader.TabIndex = 5;
            this.labelExceptionMessageHeader.Text = "Exception message";
            // 
            // textBoxExceptionMessage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxExceptionMessage, 2);
            this.textBoxExceptionMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExceptionMessage.Location = new System.Drawing.Point(33, 69);
            this.textBoxExceptionMessage.Multiline = true;
            this.textBoxExceptionMessage.Name = "textBoxExceptionMessage";
            this.textBoxExceptionMessage.ReadOnly = true;
            this.textBoxExceptionMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExceptionMessage.Size = new System.Drawing.Size(468, 33);
            this.textBoxExceptionMessage.TabIndex = 6;
            // 
            // buttonCopyAll
            // 
            this.buttonCopyAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCopyAll.Location = new System.Drawing.Point(346, 284);
            this.buttonCopyAll.Name = "buttonCopyAll";
            this.buttonCopyAll.Size = new System.Drawing.Size(75, 24);
            this.buttonCopyAll.TabIndex = 7;
            this.buttonCopyAll.Text = "Copy All";
            this.buttonCopyAll.UseVisualStyleBackColor = true;
            this.buttonCopyAll.Click += new System.EventHandler(this.buttonCopyAll_Click);
            // 
            // labelExceptionIsFatalHeader
            // 
            this.labelExceptionIsFatalHeader.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelExceptionIsFatalHeader, 2);
            this.labelExceptionIsFatalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExceptionIsFatalHeader.Location = new System.Drawing.Point(33, 30);
            this.labelExceptionIsFatalHeader.Name = "labelExceptionIsFatalHeader";
            this.labelExceptionIsFatalHeader.Size = new System.Drawing.Size(281, 16);
            this.labelExceptionIsFatalHeader.TabIndex = 8;
            this.labelExceptionIsFatalHeader.Text = "This exception will force mRemoteNG to close";
            // 
            // UnhandledExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "UnhandledExceptionWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mRemoteNG Unhandled Exception";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxStackTrace;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelExceptionCaught;
        private System.Windows.Forms.Label labelStackTraceHeader;
        private System.Windows.Forms.Label labelExceptionMessageHeader;
        private System.Windows.Forms.TextBox textBoxExceptionMessage;
        private System.Windows.Forms.Button buttonCopyAll;
        private System.Windows.Forms.Label labelExceptionIsFatalHeader;
    }
}