using Syncfusion.Maui.Picker;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TimePickerSample.Control
{
    public class CustomTimePicker : SfPicker
    {

        //Minute is the collection of minute numbers

        public PickerColumn Minute;

        //Hour is the collection of hour numbers

        public PickerColumn Hour;

        //Format is the collection of AM and PM

        public PickerColumn Format;

        private ObservableCollection<string> hours, minutes, formats;

        public CustomTimePicker()
        {
            Hour = new PickerColumn();
            Minute = new PickerColumn();
            Format = new PickerColumn();
            hours = new ObservableCollection<string>();
            minutes = new ObservableCollection<string>();
            formats = new ObservableCollection<string>();


            PopulateTimeCollection();
            this.Columns.Add(Hour);
            this.Columns.Add(Minute);
            this.Columns.Add(Format);

            this.ColumnHeaderView.Height = 40;
            this.FooterView.Height = 40;
            this.FooterView.ShowOkButton = true;
            this.HeaderView.Height = 40;
            this.HeaderView.Text = "Select Time";

            this.ColumnHeaderView.TextStyle.TextColor = Color.FromArgb("#6750A4");
            this.ColumnHeaderView.DividerColor = Color.FromArgb("#6750A4");
            this.FooterView.DividerColor = Color.FromArgb("#6750A4");
            this.HeaderView.TextStyle.TextColor = Color.FromArgb("#6750A4");
            this.TextStyle.TextColor = Color.FromArgb("#6750A4");
            this.ColumnDividerColor = Colors.Transparent;
            this.HeaderView.DividerColor = Color.FromArgb("#6750A4");
        }

        private void PopulateTimeCollection()
        {
            //Populate Hour
            for (int i = 1; i <= 12; i++)
            {
                hours.Add(i.ToString());
            }

            //Populate Minute
            for (int j = 0; j < 60; j++)
            {
                if (j < 10)
                {
                    minutes.Add("0" + j);
                }
                else
                    minutes.Add(j.ToString());
            }

            //Populate Format
            formats.Add("AM");
            formats.Add("PM");

            Hour.ItemsSource = hours;
            Minute.ItemsSource = minutes;
            Format.ItemsSource = formats;

            Hour.HeaderText = "Hour";
            Minute.HeaderText = "Minute";
        }

    }
}
