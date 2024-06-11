namespace Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NoteDescript = new TextBox();
            NoteName = new MaskedTextBox();
            Date = new DateTimePicker();
            NoteImportance = new ComboBox();
            Save = new Button();
            list_notes = new ListBox();
            Delete = new Button();
            SuspendLayout();
            // 
            // NoteDescript
            // 
            NoteDescript.AcceptsReturn = true;
            NoteDescript.AcceptsTab = true;
            NoteDescript.AllowDrop = true;
            NoteDescript.Location = new Point(12, 68);
            NoteDescript.Multiline = true;
            NoteDescript.Name = "NoteDescript";
            NoteDescript.ScrollBars = ScrollBars.Vertical;
            NoteDescript.Size = new Size(335, 162);
            NoteDescript.TabIndex = 0;
            // 
            // NoteName
            // 
            NoteName.Location = new Point(12, 10);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(335, 23);
            NoteName.TabIndex = 1;
            // 
            // Date
            // 
            Date.Location = new Point(12, 39);
            Date.Name = "Date";
            Date.Size = new Size(121, 23);
            Date.TabIndex = 2;
            // 
            // NoteImportance
            // 
            NoteImportance.Location = new Point(139, 39);
            NoteImportance.Name = "NoteImportance";
            NoteImportance.Size = new Size(208, 23);
            NoteImportance.TabIndex = 3;
            // 
            // Save
            // 
            Save.Font = new Font("Roboto Black", 16.3F, FontStyle.Bold);
            Save.Location = new Point(353, 10);
            Save.Name = "Save";
            Save.Size = new Size(75, 220);
            Save.TabIndex = 4;
            Save.Text = "Save note";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // list_notes
            // 
            list_notes.FormattingEnabled = true;
            list_notes.ItemHeight = 15;
            list_notes.Location = new Point(12, 249);
            list_notes.Name = "list_notes";
            list_notes.Size = new Size(335, 454);
            list_notes.TabIndex = 5;
            // 
            // Delete
            // 
            Delete.Font = new Font("Roboto Black", 16.3F, FontStyle.Bold);
            Delete.Location = new Point(434, 10);
            Delete.Name = "Delete";
            Delete.Size = new Size(87, 220);
            Delete.TabIndex = 6;
            Delete.Text = "Delete note";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 715);
            Controls.Add(Delete);
            Controls.Add(list_notes);
            Controls.Add(Save);
            Controls.Add(NoteImportance);
            Controls.Add(Date);
            Controls.Add(NoteName);
            Controls.Add(NoteDescript);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoteDescript;
        private MaskedTextBox NoteName;
        private DateTimePicker Date;
        private ComboBox NoteImportance;
        private Button Save;
        private ListBox list_notes;
        private Button Delete;
    }
}
