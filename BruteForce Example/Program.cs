using System;
using System.Threading;

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
    class Program
    {
        static void Main(string[] args)
        {
            Bruteforce brutef = new Bruteforce(3);
            /**foreach(String o in brutef.GetCombinations(2))
            {
                Console.WriteLine(o);
            }**/
            foreach (String o in brutef.GetAllCombinations())
            {
                Console.WriteLine(o);
            }

            Thread.Sleep(50000);
        }
    }
}
