namespace SimCorp.IMS.WinFormsMessanger {
    partial class SimCorpMessanger {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.SMSPushTimer = new System.Windows.Forms.Timer(this.components);
            this.FormatTypesBox = new System.Windows.Forms.ComboBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.MultyFilterCheck = new System.Windows.Forms.CheckBox();
            this.FiltersGroup = new System.Windows.Forms.GroupBox();
            this.DateGroup = new System.Windows.Forms.GroupBox();
            this.FiltersGroup.SuspendLayout();
            this.DateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SMSPushTimer
            // 
            this.SMSPushTimer.Enabled = true;
            this.SMSPushTimer.Interval = 1000;
            this.SMSPushTimer.Tick += new System.EventHandler(this.SMSPushTimer_Tick);
            // 
            // FormatTypesBox
            // 
            this.FormatTypesBox.FormattingEnabled = true;
            this.FormatTypesBox.Location = new System.Drawing.Point(12, 147);
            this.FormatTypesBox.Name = "FormatTypesBox";
            this.FormatTypesBox.Size = new System.Drawing.Size(237, 21);
            this.FormatTypesBox.TabIndex = 1;
            this.FormatTypesBox.SelectedIndexChanged += new System.EventHandler(this.FormatTypesBox_SelectedIndexChanged);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Message});
            this.MessageListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessageListView.LabelWrap = false;
            this.MessageListView.Location = new System.Drawing.Point(12, 205);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(513, 306);
            this.MessageListView.TabIndex = 2;
            this.MessageListView.TileSize = new System.Drawing.Size(360, 30);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            // 
            // User
            // 
            this.User.Width = 360;
            // 
            // Message
            // 
            this.Message.Width = 360;
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(6, 19);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(253, 21);
            this.UsersComboBox.TabIndex = 3;
            this.UsersComboBox.Tag = "";
            this.UsersComboBox.SelectionChangeCommitted += new System.EventHandler(this.UsersComboBox_SelectionChangeCommitted);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(6, 46);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(253, 20);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(6, 19);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 20);
            this.FromDate.TabIndex = 5;
            this.FromDate.CloseUp += new System.EventHandler(this.FromDate_CloseUp);
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(6, 45);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 20);
            this.ToDate.TabIndex = 6;
            this.ToDate.CloseUp += new System.EventHandler(this.ToDate_CloseUp);
            // 
            // MultyFilterCheck
            // 
            this.MultyFilterCheck.AutoSize = true;
            this.MultyFilterCheck.Location = new System.Drawing.Point(276, 12);
            this.MultyFilterCheck.Name = "MultyFilterCheck";
            this.MultyFilterCheck.Size = new System.Drawing.Size(76, 17);
            this.MultyFilterCheck.TabIndex = 7;
            this.MultyFilterCheck.Text = "All at once";
            this.MultyFilterCheck.UseVisualStyleBackColor = true;
            // 
            // FiltersGroup
            // 
            this.FiltersGroup.Controls.Add(this.DateGroup);
            this.FiltersGroup.Controls.Add(this.UsersComboBox);
            this.FiltersGroup.Controls.Add(this.SearchBox);
            this.FiltersGroup.Location = new System.Drawing.Point(256, 41);
            this.FiltersGroup.Name = "FiltersGroup";
            this.FiltersGroup.Size = new System.Drawing.Size(269, 158);
            this.FiltersGroup.TabIndex = 8;
            this.FiltersGroup.TabStop = false;
            this.FiltersGroup.Text = "Filters";
            // 
            // DateGroup
            // 
            this.DateGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DateGroup.Controls.Add(this.FromDate);
            this.DateGroup.Controls.Add(this.ToDate);
            this.DateGroup.Location = new System.Drawing.Point(6, 70);
            this.DateGroup.Name = "DateGroup";
            this.DateGroup.Size = new System.Drawing.Size(216, 78);
            this.DateGroup.TabIndex = 7;
            this.DateGroup.TabStop = false;
            this.DateGroup.Text = "Dates";
            // 
            // SimCorpMessanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 521);
            this.Controls.Add(this.FiltersGroup);
            this.Controls.Add(this.MultyFilterCheck);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.FormatTypesBox);
            this.MaximizeBox = false;
            this.Name = "SimCorpMessanger";
            this.Text = "SimCorp Messanger";
            this.FiltersGroup.ResumeLayout(false);
            this.FiltersGroup.PerformLayout();
            this.DateGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer SMSPushTimer;
        private System.Windows.Forms.ComboBox FormatTypesBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.CheckBox MultyFilterCheck;
        private System.Windows.Forms.GroupBox FiltersGroup;
        private System.Windows.Forms.GroupBox DateGroup;
    }
}

