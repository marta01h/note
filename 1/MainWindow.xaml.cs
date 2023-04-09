﻿< Grid >
        < Grid.ColumnDefinitions >
            < ColumnDefinition Width = "191*" />
            < ColumnDefinition Width = "51*" />
            < ColumnDefinition Width = "129*" />
            < ColumnDefinition Width = "146*" />
        </ Grid.ColumnDefinitions >
        < Grid.RowDefinitions >
            < RowDefinition Height = "85*" ></ RowDefinition >
            < RowDefinition Height = "79*" ></ RowDefinition >
            < RowDefinition Height = "83*" ></ RowDefinition >
        </ Grid.RowDefinitions >


        < Calendar Grid.Column = "0" Grid.Row = "0"
        SelectedDatesChanged = "Calendar_SelectedDatesChanged" />
        < TabControl TabStripPlacement = "Top" Grid.Column = "1" Grid.Row = "0" Grid.ColumnSpan = "3" Grid.RowSpan = "3" >
            < TabItem Header = "Daily" >
                < Grid >
                    < Grid.ColumnDefinitions >
                        < ColumnDefinition Width = "50" />
                        < ColumnDefinition />
                        < ColumnDefinition />
                    </ Grid.ColumnDefinitions >
                    < StackPanel Grid.Column = "0" >
                        < ListBox Name = "Lb" SelectionMode = "Single" SelectionChanged = "Lb_SelectionChanged" HorizontalAlignment = "Left" Width = "50" >
                            < ListBoxItem Content = "7.00" Height = "27" />
                            < ListBoxItem Content = "8.00"  Height = "27" />
                            < ListBoxItem Content = "9.00"  Height = "27" />
                            < ListBoxItem Content = "10.00" Height = "30" />
                            < ListBoxItem Content = "11.00" Height = "30" />
                            < ListBoxItem Content = "12.00" Height = "30" />
                            < ListBoxItem Content = "13.00" Height = "30" />
                            < ListBoxItem Content = "14.00" Height = "30" />
                            < ListBoxItem Content = "15.00" Height = "30" />
                            < ListBoxItem Content = "16.00" Height = "28" />
                            < ListBoxItem Content = "17.00" Height = "27" />
                            < ListBoxItem Content = "18.00" Height = "28" />
                            < ListBoxItem Content = "19.00" Height = "30" />
                            < ListBoxItem Content = "20.00" Height = "30" />
                            < ListBoxItem Content = "21.00" Height = "25" />
                            < ListBoxItem Content = "22.00" Height = "29" />


                        </ ListBox >
                    </ StackPanel >
                    < StackPanel Grid.Column = "1" Grid.ColumnSpan = "2" HorizontalAlignment = "Stretch" >
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto"  Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />
                        < TextBox ScrollViewer.VerticalScrollBarVisibility = "Auto" Height = "25" Margin = "2" />


                    </ StackPanel >
                </ Grid >
            </ TabItem >
            < TabItem Header = "Week" >
                < Grid >
                    < Grid.ColumnDefinitions >
                        < ColumnDefinition />
                        < ColumnDefinition />
                        < ColumnDefinition />
                        < ColumnDefinition />
                        < ColumnDefinition />
                    </ Grid.ColumnDefinitions >
                    < Grid.RowDefinitions >
                        < RowDefinition />
                        < RowDefinition />
                        < RowDefinition />
                        < RowDefinition />
                        < RowDefinition />
                        < RowDefinition />
                    </ Grid.RowDefinitions >
                </ Grid >
            </ TabItem >
            < TabItem Header = "Month" >
            </ TabItem >
        </ TabControl >
        < Label Name = "Label1"  Grid.Column = "0" Grid.Row = "2" HorizontalAlignment = "Center" FontSize = "45" Margin = "90,0,91,0" Width = "10" />


    </ Grid >