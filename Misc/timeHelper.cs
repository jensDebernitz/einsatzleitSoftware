/*
 * Created by SharpDevelop.
 * User: jens.debernitz
 * Date: 16.02.2017
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Misc
{
	/// <summary>
	/// Description of timeHelper2.
	/// </summary>
	public class timeHelper
	{
		public timeHelper()
		{
		}

        public string getDiffTime(DateTime startTime)
        {
            string returnValue = String.Empty;
            DateTime localDateTime = DateTime.Now;
            TimeSpan diff = localDateTime - startTime;
            int diffHours = diff.Hours;
            int diffMinutes = diff.Minutes;
            int diffSeconds = diff.Seconds;
            returnValue = diffHours.ToString() + ":" + diffMinutes.ToString() + ":" + diffSeconds.ToString();
            
            return returnValue;
        }

        public bool is15MinutesAlarm(DateTime startTime)
        {
            bool returnValue = false;
            DateTime localDateTime = DateTime.Now;
            TimeSpan diff = localDateTime - startTime;
            int diffHours = diff.Hours;
            int diffMinutes = diff.Minutes;
            int diffSeconds = diff.Seconds;

            if(diffSeconds == 0 && (diffMinutes % 15) == 0 && diffMinutes != 0)
            {
                returnValue = true;
            }

            return returnValue;

        }
	}
}
