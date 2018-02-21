using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/**
    A simple brute force example project
    
    Copyright (C) 2018  Rafael Orman

    The BruteForce Example is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    You should have received a copy of the GNU General Public License
    along with this program. If not, see <http://www.gnu.org/licenses/>.
**/

namespace BruteForce_Example
{

    class Bruteforce
    {
        #region Private vars
        private static char[] chars =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z','A','B','C','D','E',
            'F','G','H','I','J','K','L','M','N','O','P','Q','R',
            'S','T','U','V','W','X','Y','Z','1','2','3','4','5',
            '6','7','8','9','0','!','$','#','@','-'
        };
        #endregion

        private int length;
        private char[] charst;

        public Bruteforce(int length, char[] charsToTest)
        {
            this.length = length;
            this.charst = charsToTest;
        }

        public Bruteforce(int length) : this(length, chars) { }

        public String[] GetAllCombinations()
        {
            List<String> list = new List<String>();
            for (int i = 1; i <= length; i++)
            {
                String[] combs = GetCombinations(i);

                list.AddRange(combs);
            }

            return list.Select(i => i.ToString()).ToArray();
        }

        public Boolean Rekursive(int[] combs, int digitI)
        {
            combs[digitI] = NextChar(combs[digitI]);

            if(combs[digitI] == -1)
            {
                combs[digitI] = 0;

                if ((digitI + 1) < combs.Length)
                {
                    return Rekursive(combs, digitI + 1);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public String[] GetCombinations(int length)
        {
            List<String> list = new List<String>();
            int[] combs = new int[length];
            String outs = "";

            while(true)
            {
                for (int i = 0; i < combs.Length; i++)
                {
                    if (combs[combs.Length - 1] == -1)
                    {
                        break;
                    }

                    outs += charst[combs[i]];
                }

                list.Add(outs);
                outs = "";

                int cchar = combs[0];
                int next = NextChar(cchar);

                if (Rekursive(combs, 0))
                {
                    break;
                }
            }

            return list.Select(i => i.ToString()).ToArray();
        }

        private int NextChar(int index)
        {
            if ((index + 1) < charst.Length)
            {
                return index + 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
