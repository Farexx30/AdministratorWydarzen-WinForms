namespace AdministratorWydarzen_WinForms
{
    partial class EventView
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
            components = new System.ComponentModel.Container();
            CreateEventGroupBox = new GroupBox();
            AddEventButton = new Button();
            PriorityComboBox = new ComboBox();
            PriorityLabel = new Label();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            EventDateLabel = new Label();
            EventDateDateTimePicker = new DateTimePicker();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            DeleteEventButton = new Button();
            AllEventsListBox = new ListBox();
            AllEventsGroupBox = new GroupBox();
            SortByLabel = new Label();
            FilteryByLabel = new Label();
            SearchByTextBox = new TextBox();
            SortByComboxBox = new ComboBox();
            FilterByComboBox = new ComboBox();
            EventDetailsGroupBox = new GroupBox();
            EventDetailsTextBox = new TextBox();
            EventCreatorErrorProvider = new ErrorProvider(components);
            CreateEventGroupBox.SuspendLayout();
            AllEventsGroupBox.SuspendLayout();
            EventDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventCreatorErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // CreateEventGroupBox
            // 
            CreateEventGroupBox.Controls.Add(AddEventButton);
            CreateEventGroupBox.Controls.Add(PriorityComboBox);
            CreateEventGroupBox.Controls.Add(PriorityLabel);
            CreateEventGroupBox.Controls.Add(TypeLabel);
            CreateEventGroupBox.Controls.Add(TypeComboBox);
            CreateEventGroupBox.Controls.Add(EventDateLabel);
            CreateEventGroupBox.Controls.Add(EventDateDateTimePicker);
            CreateEventGroupBox.Controls.Add(DescriptionTextBox);
            CreateEventGroupBox.Controls.Add(DescriptionLabel);
            CreateEventGroupBox.Controls.Add(TitleLabel);
            CreateEventGroupBox.Controls.Add(TitleTextBox);
            CreateEventGroupBox.Location = new Point(12, 12);
            CreateEventGroupBox.Name = "CreateEventGroupBox";
            CreateEventGroupBox.Size = new Size(334, 403);
            CreateEventGroupBox.TabIndex = 0;
            CreateEventGroupBox.TabStop = false;
            CreateEventGroupBox.Text = "Informacje o wydarzeniu";
            // 
            // AddEventButton
            // 
            AddEventButton.Location = new Point(118, 353);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(86, 22);
            AddEventButton.TabIndex = 11;
            AddEventButton.Text = "Dodaj";
            AddEventButton.UseVisualStyleBackColor = true;
            AddEventButton.Click += AddEventButton_Click;
            // 
            // PriorityComboBox
            // 
            PriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityComboBox.FormattingEnabled = true;
            PriorityComboBox.Items.AddRange(new object[] { "Niski", "Średni", "Wysoki" });
            PriorityComboBox.Location = new Point(111, 294);
            PriorityComboBox.Name = "PriorityComboBox";
            PriorityComboBox.Size = new Size(154, 23);
            PriorityComboBox.TabIndex = 10;
            PriorityComboBox.SelectedIndex = 0;
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Location = new Point(6, 294);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(55, 15);
            PriorityLabel.TabIndex = 9;
            PriorityLabel.Text = "Priorytet:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(6, 246);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(28, 15);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Typ:";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Praca", "Rodzina", "Rozrywka", "Zdrowie", "Sport" });
            TypeComboBox.Location = new Point(111, 246);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(154, 23);
            TypeComboBox.TabIndex = 7;
            TypeComboBox.SelectedIndex = 1;
            // 
            // EventDateLabel
            // 
            EventDateLabel.AutoSize = true;
            EventDateLabel.Location = new Point(6, 200);
            EventDateLabel.Name = "EventDateLabel";
            EventDateLabel.Size = new Size(99, 15);
            EventDateLabel.TabIndex = 6;
            EventDateLabel.Text = "Data rozpoczęcia:";
            // 
            // EventDateDateTimePicker
            // 
            EventDateDateTimePicker.CalendarFont = new Font("Segoe UI", 9F);
            EventDateDateTimePicker.CustomFormat = "dd.MM.yyyy";
            EventDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            EventDateDateTimePicker.Location = new Point(111, 200);
            EventDateDateTimePicker.Name = "EventDateDateTimePicker";
            EventDateDateTimePicker.Size = new Size(154, 23);
            EventDateDateTimePicker.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(111, 79);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(189, 100);
            DescriptionTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AccessibleRole = AccessibleRole.SplitButton;
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 79);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(34, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Opis:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(6, 34);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(35, 15);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Tytuł:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(111, 34);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(154, 23);
            TitleTextBox.TabIndex = 0;
            // 
            // DeleteEventButton
            // 
            DeleteEventButton.Location = new Point(358, 416);
            DeleteEventButton.Name = "DeleteEventButton";
            DeleteEventButton.Size = new Size(86, 22);
            DeleteEventButton.TabIndex = 12;
            DeleteEventButton.Text = "Usuń";
            DeleteEventButton.UseVisualStyleBackColor = true;
            // 
            // AllEventsListBox
            // 
            AllEventsListBox.Font = new Font("Segoe UI", 15F);
            AllEventsListBox.FormattingEnabled = true;
            AllEventsListBox.ItemHeight = 28;
            AllEventsListBox.Location = new Point(0, 74);
            AllEventsListBox.Name = "AllEventsListBox";
            AllEventsListBox.Size = new Size(434, 200);
            AllEventsListBox.TabIndex = 13;
            // 
            // AllEventsGroupBox
            // 
            AllEventsGroupBox.Controls.Add(SortByLabel);
            AllEventsGroupBox.Controls.Add(FilteryByLabel);
            AllEventsGroupBox.Controls.Add(SearchByTextBox);
            AllEventsGroupBox.Controls.Add(SortByComboxBox);
            AllEventsGroupBox.Controls.Add(FilterByComboBox);
            AllEventsGroupBox.Controls.Add(AllEventsListBox);
            AllEventsGroupBox.Location = new Point(356, 12);
            AllEventsGroupBox.Name = "AllEventsGroupBox";
            AllEventsGroupBox.Size = new Size(434, 274);
            AllEventsGroupBox.TabIndex = 13;
            AllEventsGroupBox.TabStop = false;
            AllEventsGroupBox.Text = "Wszystkie wydarzenia";
            // 
            // SortByLabel
            // 
            SortByLabel.AutoSize = true;
            SortByLabel.Location = new Point(230, 19);
            SortByLabel.Name = "SortByLabel";
            SortByLabel.Size = new Size(58, 15);
            SortByLabel.TabIndex = 18;
            SortByLabel.Text = "Sortuj po:";
            // 
            // FilteryByLabel
            // 
            FilteryByLabel.AutoSize = true;
            FilteryByLabel.Location = new Point(129, 19);
            FilteryByLabel.Name = "FilteryByLabel";
            FilteryByLabel.Size = new Size(57, 15);
            FilteryByLabel.TabIndex = 17;
            FilteryByLabel.Text = "Filtruj po:";
            // 
            // SearchByTextBox
            // 
            SearchByTextBox.ForeColor = Color.LightGray;
            SearchByTextBox.Location = new Point(10, 34);
            SearchByTextBox.Name = "SearchByTextBox";
            SearchByTextBox.Size = new Size(95, 23);
            SearchByTextBox.TabIndex = 16;
            SearchByTextBox.Text = "Szukaj...";
            SearchByTextBox.Enter += SearchByTextBoxEnter;
            SearchByTextBox.Leave += SearchByTextBoxLeave;
            // 
            // SortByComboxBox
            // 
            SortByComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortByComboxBox.DropDownWidth = 95;
            SortByComboxBox.FormattingEnabled = true;
            SortByComboxBox.Items.AddRange(new object[] { "Data", "Typ", "Priorytet" });
            SortByComboxBox.Location = new Point(231, 34);
            SortByComboxBox.Name = "SortByComboxBox";
            SortByComboxBox.Size = new Size(95, 23);
            SortByComboxBox.TabIndex = 15;
            SortByComboxBox.SelectedIndex = 0;
            // 
            // FilterByComboBox
            // 
            FilterByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByComboBox.FormattingEnabled = true;
            FilterByComboBox.Items.AddRange(new object[] { "Data", "Typ", "Priorytet" });
            FilterByComboBox.Location = new Point(129, 34);
            FilterByComboBox.Name = "FilterByComboBox";
            FilterByComboBox.Size = new Size(95, 23);
            FilterByComboBox.TabIndex = 14;
            FilterByComboBox.SelectedIndex = 1;
            // 
            // EventDetailsGroupBox
            // 
            EventDetailsGroupBox.Controls.Add(EventDetailsTextBox);
            EventDetailsGroupBox.Location = new Point(356, 292);
            EventDetailsGroupBox.Name = "EventDetailsGroupBox";
            EventDetailsGroupBox.Size = new Size(434, 123);
            EventDetailsGroupBox.TabIndex = 14;
            EventDetailsGroupBox.TabStop = false;
            EventDetailsGroupBox.Text = "Szczegóły wydarzenia";
            // 
            // EventDetailsTextBox
            // 
            EventDetailsTextBox.Location = new Point(2, 22);
            EventDetailsTextBox.Name = "EventDetailsTextBox";
            EventDetailsTextBox.ReadOnly = true;
            EventDetailsTextBox.AutoSize = false;
            EventDetailsTextBox.Size = new Size(432, 100);
            EventDetailsTextBox.TabIndex = 0;
            // 
            // EventCreatorErrorProvider
            // 
            EventCreatorErrorProvider.ContainerControl = this;
            // 
            // EventView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EventDetailsGroupBox);
            Controls.Add(AllEventsGroupBox);
            Controls.Add(DeleteEventButton);
            Controls.Add(CreateEventGroupBox);
            Name = "EventView";
            Text = "Administator wydarzeń";
            CreateEventGroupBox.ResumeLayout(false);
            CreateEventGroupBox.PerformLayout();
            AllEventsGroupBox.ResumeLayout(false);
            AllEventsGroupBox.PerformLayout();
            EventDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EventCreatorErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CreateEventGroupBox;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBox;
        private DateTimePicker EventDateDateTimePicker;
        private Label EventDateLabel;
        private ComboBox TypeComboBox;
        private ComboBox PriorityComboBox;
        private Label PriorityLabel;
        private Label TypeLabel;
        private Button AddEventButton;
        private Button DeleteEventButton;
        private ListBox AllEventsListBox;
        private GroupBox AllEventsGroupBox;
        private GroupBox EventDetailsGroupBox;
        private TextBox EventDetailsTextBox;
        private ComboBox SortByComboxBox;
        private ComboBox FilterByComboBox;
        private TextBox SearchByTextBox;
        private Label FilteryByLabel;
        private Label SortByLabel;
        private ErrorProvider EventCreatorErrorProvider;
    }
}
