using System;

namespace Almostengr.HdHomerunCron
{
    public class UserInterface
    {
        protected void PrintMainMenu()
        {

            Console.WriteLine("MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1) Show recordings");
            Console.WriteLine("2) Add recording");
            Console.WriteLine("3) Remove recording");
            Console.WriteLine("0) Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your selection: ");
            string menuSelection = Console.ReadLine().Trim();

            switch (menuSelection)
            {
                case "1":
                    ShowSchedule();
                    break;

                case "2":
                    AddJob();
                    break;

                case "3":
                    RemoveJob();
                    break;

                case "Q":
                case "q":
                    return;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

        }

        private void ShowSchedule()
        {
            throw new NotImplementedException();
        }

        private void RemoveJob()
        {
            throw new NotImplementedException();
        }

        protected void AddJob(string hostname)
        {
            CronJobRecording cronJobRecording = new CronJobRecording();

            Console.WriteLine("Name of the show");
            cronJobRecording.ShowName = Console.ReadLine();

            bool doLoop = true;
            while (doLoop)
            {
                try
                {
                    Console.WriteLine("Enter the hour the show starts");
                    cronJobRecording.Hour = Int32.Parse(Console.ReadLine());
                    doLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid hour entered. Please try again");
                }
            }

            doLoop = true;
            while (doLoop)
            {
                try
                {
                    Console.WriteLine("Enter the minute the show starts");
                    cronJobRecording.Minute = Int32.Parse(Console.ReadLine());
                    // string minute = Console.ReadLine();
                    doLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid minute entered. Please try again");
                }
            }

            doLoop = true;
            while (doLoop)
            {
                try
                {
                    Console.WriteLine("Enter the day of the week the show airs");
                    Console.WriteLine("0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday");
                    Console.WriteLine("4 = Thursday, 5 = Friday, 6 = Saturday");
                    // string dayOfWeek = Console.ReadLine().ToLower();
                    cronJobRecording.DayOfWeek = Int32.Parse(Console.ReadLine());
                    doLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Enter the channel number to record");
            string channelNumber = Console.ReadLine();

            Console.WriteLine("How long is the show (in minutes)?");
            // string duration = Console.ReadLine();

            doLoop = true;
            while (doLoop)
            {
                try
                {
                    Console.WriteLine("How long is the show (in minutes)?");
                    // string dayOfWeek = Console.ReadLine().ToLower();
                    cronJobRecording.DurationMinutes = Int32.Parse(Console.ReadLine());
                    doLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                }
            }

            // TODO write to end of crontab file

        }
    }
}