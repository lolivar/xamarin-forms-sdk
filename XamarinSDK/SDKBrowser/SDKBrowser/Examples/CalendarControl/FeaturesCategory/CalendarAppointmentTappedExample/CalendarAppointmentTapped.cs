﻿using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CalendarAppointmentTappedExample
{
    public class CalendarAppointmentTapped : ContentView
    {
        public CalendarAppointmentTapped()
        {
            // >> calendar-gettingstarted-appointmentssource-csharp
            var date = DateTime.Today;

            var calendar = new RadCalendar
            {
                DisplayDate = date,  
                AppointmentsSource = new List<Appointment> {
                    new Appointment {
                        Title = "Meeting with Tom",
                        Detail = "Sea Garden",
                        StartDate = date.AddHours(10),
                        EndDate = date.AddHours(11),
                        Color = Color.Tomato
                    },
                    new Appointment {
                        Title = "Lunch with Sara",
                        Detail = "Restaurant",
                        StartDate = date.AddHours(12).AddMinutes(30),
                        EndDate = date.AddHours(14),
                        Color = Color.DarkTurquoise
                    },
                    new Appointment {
                        Title = "Elle Birthday",
                        StartDate = date.AddDays(1),
                        EndDate = date.AddDays(1).AddHours(12),
                        IsAllDay = true
                    },
                     new Appointment {
                        Title = "Football Game",
                        StartDate = date.AddDays(2).AddHours(15),
                        EndDate = date.AddDays(2).AddHours(17),
                        Color = Color.Green
                    }
                }
            };
            // << calendar-gettingstarted-appointmentssource-csharp

            // >> calendar-features-setviewmode-csharp
            calendar.ViewMode = CalendarViewMode.Day;
            // << calendar-features-setviewmode-csharp

            // >> calendar-features-appointmenttapped-csharp
            calendar.AppointmentTapped += (sender, e) =>
            {
                Application.Current.MainPage.DisplayAlert(e.Appointment.Title, e.Appointment.Detail, "OK");
            };
            // << calendar-features-appointmenttapped-csharp
            this.Content = calendar;
        }
    }
}
