/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Büro Debernitz
 * Datum: 15.02.2017
 * Zeit: 21:01
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Misc
{
	/// <summary>
	/// Description of Debug.
	/// </summary>
	public class debug
	{
		// debug printf filter ids
        public enum DebugIds
        {
            DEBUG_NONE,
            DEBUG_ANY,
            DEBUG_MAINFORM,

            DEBUG_ALL,
            DEBUG_MAX,

        } ;

		int[] mDebugMask;

		public debug()
		{
            int maxSize = ((int)DebugIds.DEBUG_MAX + 7) / 8;
            mDebugMask = new int[maxSize];
		}

        public bool isDebugEnabled(DebugIds debugId)
        {
            return ((mDebugMask[(int)DebugIds.DEBUG_ALL / 8] & (1 << ((int)DebugIds.DEBUG_ALL & 0x07))) != 0)
                    | ((mDebugMask[(int)debugId / 8] & (1 << ((int)debugId & 0x07))) != 0);
        }

        public void debugMaskClear()
        {
            for(int i = 0; i < mDebugMask.Length; i++)
            {
                mDebugMask[i] = 0;
            }
        }

        public void debugMaskSet(DebugIds debugId)
        {
            mDebugMask[(int)debugId / 8] |= (1 << ((int)debugId & 0x07));
        }

        public void dprintf(string fileName, int lineNb, DebugIds debugId, string message)
        {
           if (isDebugEnabled(debugId))
           {
               DateTime x = DateTime.Now;
               Debug.WriteLine("DPRINTF " + fileName + " " + lineNb + " " + x.ToShortTimeString() + ": " + message);
           }
        }

        public void _dprintfSetMask(params DebugIds[] list)
        {
            debugMaskClear();
            debugMaskSet(DebugIds.DEBUG_ANY);

            for (int i = 0; i < list.Length; i++)
            {
                debugMaskSet(list[i]);
            }
        }
	}
}