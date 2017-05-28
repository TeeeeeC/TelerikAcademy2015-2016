using System;

class ConvertNumAsWord
{
    static void Main()
    {
        /*
         Problem 11.* Number as Words
            Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
         */
        Console.WriteLine(" Program that convert given number from [0 - 999] to text \n");
        int number = 0;
        string str = "";

        do
        {
            Console.Write(" Insert number [0 - 999]: ");
            str = Console.ReadLine();
            int.TryParse(str, out number);

        } while ((((str.Length == 3) || (str.Length == 2)) && (str[0] == '0')) || ((number < 0) || (number > 999)) || ((!(int.TryParse(str, out number)))));

        char firstDigit = str[0];

        switch (firstDigit)
        {
            case '0':
                        Console.WriteLine();
                        Console.WriteLine(" The number is: 0 -> \"Null\""); break;
            case '1': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 1 -> \"One\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];

                                switch (secondDigit)
                                {
                                    case '0':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 100 -> \"One hundred\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 101 -> \"One hundred and one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 102 -> \"One hundred and two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 103 -> \"One hundred and three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 104 -> \"One hundred and four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 105 -> \"One hundred and five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 106 -> \"One hundred and six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 107 -> \"One hundred and seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 108 -> \"One hundred and eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 109 -> \"One hundred and nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(" The number is: 10 -> \"Ten\""); 
                                        } break;

                                    case '1':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 110 -> \"One hundred and ten\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 111 -> \"One hundred and eleven\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 112 -> \"One hundred and twelve\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 113 -> \"One hundred and tirteen\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 114 -> \"One hundred and fourteen\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 115 -> \"One hundred and fifteen\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 116 -> \"One hundred and sixteen\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 117 -> \"One hundred and seventeen\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 118 -> \"One hundred and eighteen\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 119 -> \"One hundred and nineteen\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 11 -> \"Eleven\""); 
                                        } break;
                                    case '2':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 120 -> \"One hundred twenty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 121 -> \"One hundred twenty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 122 -> \"One hundred twenty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 123 -> \"One hundred twenty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 124 -> \"One hundred twenty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 125 -> \"One hundred twenty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 126 -> \"One hundred twenty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 127 -> \"One hundred twenty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 128 -> \"One hundred twenty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 129 -> \"One hundred twenty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 12 -> \"Twelve\""); 
                                        } break;

                                    case '3': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 130 -> \"One hundred thirty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 131 -> \"One hundred thirty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 132 -> \"One hundred thirty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 133 -> \"One hundred thirty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 134 -> \"One hundred thirty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 135 -> \"One hundred thirty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 136 -> \"One hundred thirty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 137 -> \"One hundred thirty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 138 -> \"One hundred thirty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 139 -> \"One hundred thirty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 13 -> \"Thirteen\""); 
                                        } break;

                                    case '4':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 140 -> \"One hundred forty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 141 -> \"One hundred forty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 142 -> \"One hundred forty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 143 -> \"One hundred forty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 144 -> \"One hundred forty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 145 -> \"One hundred forty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 146 -> \"One hundred forty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 147 -> \"One hundred forty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 148 -> \"One hundred forty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 149 -> \"One hundred forty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 14 -> \"Fourteen\""); 
                                        } break;

                                    case '5': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 150 -> \"One hundred fifty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 151 -> \"One hundred fifty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 152 -> \"One hundred fifty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 153 -> \"One hundred fifty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 154 -> \"One hundred fifty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 155 -> \"One hundred fifty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 156 -> \"One hundred fifty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 157 -> \"One hundred fifty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 158 -> \"One hundred fifty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 159 -> \"One hundred fifty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 15 -> \"Fifteen\""); 
                                        } break;

                                    case '6':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 160 -> \"One hundred sixty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 161 -> \"One hundred sixty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 162 -> \"One hundred sixty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 163 -> \"One hundred sixty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 164 -> \"One hundred sixty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 165 -> \"One hundred sixty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 166 -> \"One hundred sixty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 167 -> \"One hundred sixty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 168 -> \"One hundred sixty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 169 -> \"One hundred sixty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 16 -> \"Sixteen\"");
                                         } break;

                                    case '7':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 170 -> \"One hundred seventy\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 171 -> \"One hundred seventy one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 172 -> \"One hundred seventy two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 173 -> \"One hundred seventy three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 174 -> \"One hundred seventy four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 175 -> \"One hundred seventy five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 176 -> \"One hundred seventy six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 177 -> \"One hundred seventy seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 178 -> \"One hundred seventy eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 179 -> \"One hundred seventy nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 17 -> \"Seventeen\"");
                                         } break;

                                    case '8':
                                         if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 180 -> \"One hundred eighty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 181 -> \"One hundred eighty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 182 -> \"One hundred eighty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 183 -> \"One hundred eighty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 184 -> \"One hundred eighty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 185 -> \"One hundred eighty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 186 -> \"One hundred eighty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 187 -> \"One hundred eighty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 188 -> \"One hundred eighty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 189 -> \"One hundred eighty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 18 -> \"Eighteen\"");
                                        } break;

                                    case '9': 
                                        if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 190 -> \"One hundred ninety\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 191 -> \"One hundred ninety one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 192 -> \"One hundred ninety two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 193 -> \"One hundred ninety three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 194 -> \"One hundred ninety four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 195 -> \"One hundred ninety five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 196 -> \"One hundred ninety six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 197 -> \"One hundred ninety seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 198 -> \"One hundred ninety eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 199 -> \"One hundred ninety nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 19 -> \"Nineteen\"");
                                        } break;
                                }
                            }
                        }break;
            case '2': 
                if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 2 -> \"Two\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];

                                switch (secondDigit)
                                {
                                    case '0':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 200 -> \"Two hundred\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 201 -> \"Two hundred and one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 202 -> \"Two hundred and two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 203 -> \"Two hundred and three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 204 -> \"Two hundred and four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 205 -> \"Two hundred and five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 206 -> \"Two hundred and six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 207 -> \"Two hundred and seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 208 -> \"Two hundred and eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 209 -> \"Two hundred and nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(" The number is: 20 -> \"Twenty\""); 
                                        } break;

                                    case '1':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 210 -> \"Two hundred and ten\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 211 -> \"Two hundred and eleven\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 212 -> \"Two hundred and twelve\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 213 -> \"Two hundred and tirteen\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 214 -> \"Two hundred and fourteen\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 215 -> \"Two hundred and fifteen\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 216 -> \"Two hundred and sixteen\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 217 -> \"Two hundred and seventeen\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 218 -> \"Two hundred and eighteen\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 219 -> \"Two hundred and nineteen\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 21 -> \"Twenty one\""); 
                                        } break;
                                    case '2':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 220 -> \"Two hundred twenty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 221 -> \"Two hundred twenty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 222 -> \"Two hundred twenty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 223 -> \"Two hundred twenty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 224 -> \"Two hundred twenty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 225 -> \"Two hundred twenty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 226 -> \"Two hundred twenty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 227 -> \"Two hundred twenty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 228 -> \"Two hundred twenty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 229 -> \"Two hundred twenty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 22 -> \"Twenty two\""); 
                                        } break;

                                    case '3': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 230 -> \"Two hundred thirty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 231 -> \"Two hundred thirty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 232 -> \"Two hundred thirty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 233 -> \"Two hundred thirty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 234 -> \"Two hundred thirty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 235 -> \"Two hundred thirty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 236 -> \"Two hundred thirty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 237 -> \"Two hundred thirty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 238 -> \"Two hundred thirty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 239 -> \"Two hundred thirty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 23 -> \"Twenty three\""); 
                                        } break;

                                    case '4':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 240 -> \"Two hundred forty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 241 -> \"Two hundred forty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 242 -> \"Two hundred forty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 243 -> \"Two hundred forty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 244 -> \"Two hundred forty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 245 -> \"Two hundred forty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 246 -> \"Two hundred forty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 247 -> \"Two hundred forty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 248 -> \"Two hundred forty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 249 -> \"Two hundred forty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 24 -> \"Twenty four\""); 
                                        } break;

                                    case '5': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 250 -> \"Two hundred fifty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 251 -> \"Two hundred fifty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 252 -> \"Two hundred fifty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 253 -> \"Two hundred fifty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 254 -> \"Two hundred fifty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 255 -> \"Two hundred fifty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 256 -> \"Two hundred fifty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 257 -> \"Two hundred fifty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 258 -> \"Two hundred fifty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 259 -> \"Two hundred fifty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 25 -> \"Twenty five\""); 
                                        } break;

                                    case '6':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 260 -> \"Two hundred sixty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 261 -> \"Two hundred sixty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 262 -> \"Two hundred sixty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 263 -> \"Two hundred sixty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 264 -> \"Two hundred sixty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 265 -> \"Two hundred sixty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 266 -> \"Two hundred sixty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 267 -> \"Two hundred sixty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 268 -> \"Two hundred sixty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 269 -> \"Two hundred sixty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 26 -> \"Twenty six\"");
                                         } break;

                                    case '7':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 270 -> \"Two hundred seventy\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 271 -> \"Two hundred seventy one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 272 -> \"Two hundred seventy two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 273 -> \"Two hundred seventy three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 274 -> \"Two hundred seventy four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 275 -> \"Two hundred seventy five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 276 -> \"Two hundred seventy six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 277 -> \"Two hundred seventy seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 278 -> \"Two hundred seventy eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 279 -> \"Two hundred seventy nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 27 -> \"Twenty seven\"");
                                         } break;

                                    case '8':
                                         if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 280 -> \"Two hundred eighty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 281 -> \"Two hundred eighty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 282 -> \"Two hundred eighty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 283 -> \"Two hundred eighty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 284 -> \"Two hundred eighty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 285 -> \"Two hundred eighty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 286 -> \"Two hundred eighty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 287 -> \"Two hundred eighty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 288 -> \"Two hundred eighty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 289 -> \"Two hundred eighty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 28 -> \"Twenty eight\"");
                                        } break;

                                    case '9': 
                                        if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 290 -> \"Two hundred ninety\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 291 -> \"Two hundred ninety one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 292 -> \"Two hundred ninety two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 293 -> \"Two hundred ninety three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 294 -> \"Two hundred ninety four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 295 -> \"Two hundred ninety five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 296 -> \"Two hundred ninety six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 297 -> \"Two hundred ninety seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 298 -> \"Two hundred ninety eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 299 -> \"Two hundred ninety nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 29 -> \"Twenty nine\"");
                                        } break;
                                }
                            }
                        } break;
            case '3': 
                if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 3 -> \"Three\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];

                                switch (secondDigit)
                                {
                                    case '0':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 300 -> \"Three hundred\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 301 -> \"Three hundred and one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 302 -> \"Three hundred and two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 303 -> \"Three hundred and three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 304 -> \"Three hundred and four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 305 -> \"Three hundred and five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 306 -> \"Three hundred and six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 307 -> \"Three hundred and seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 308 -> \"Three hundred and eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 309 -> \"Three hundred and nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(" The number is: 30 -> \"Thirty\""); 
                                        } break;

                                    case '1':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 310 -> \"Three hundred and ten\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 311 -> \"Three hundred and eleven\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 312 -> \"Three hundred and twelve\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 313 -> \"Three hundred and tirteen\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 314 -> \"Three hundred and fourteen\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 315 -> \"Three hundred and fifteen\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 316 -> \"Three hundred and sixteen\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 317 -> \"Three hundred and seventeen\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 318 -> \"Three hundred and eighteen\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 319 -> \"Three hundred and nineteen\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 31 -> \"Thirty one\""); 
                                        } break;
                                    case '2':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 320 -> \"Three hundred twenty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 321 -> \"Three hundred twenty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 322 -> \"Three hundred twenty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 323 -> \"Three hundred twenty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 324 -> \"Three hundred twenty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 325 -> \"Three hundred twenty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 326 -> \"Three hundred twenty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 327 -> \"Three hundred twenty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 328 -> \"Three hundred twenty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 329 -> \"Three hundred twenty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 32 -> \"Thirty two\""); 
                                        } break;

                                    case '3': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 330 -> \"Three hundred thirty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 331 -> \"Three hundred thirty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 332 -> \"Three hundred thirty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 333 -> \"Three hundred thirty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 334 -> \"Three hundred thirty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 335 -> \"Three hundred thirty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 336 -> \"Three hundred thirty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 337 -> \"Three hundred thirty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 338 -> \"Three hundred thirty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 339 -> \"Three hundred thirty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 33 -> \"Thirty three\""); 
                                        } break;

                                    case '4':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 340 -> \"Three hundred forty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 341 -> \"Three hundred forty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 342 -> \"Three hundred forty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 343 -> \"Three hundred forty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 344 -> \"Three hundred forty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 345 -> \"Three hundred forty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 346 -> \"Three hundred forty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 347 -> \"Three hundred forty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 348 -> \"Three hundred forty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 349 -> \"Three hundred forty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 34 -> \"Thirty four\""); 
                                        } break;

                                    case '5': 
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 350 -> \"Three hundred fifty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 351 -> \"Three hundred fifty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 352 -> \"Three hundred fifty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 353 -> \"Three hundred fifty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 354 -> \"Three hundred fifty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 355 -> \"Three hundred fifty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 356 -> \"Three hundred fifty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 357 -> \"Three hundred fifty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 358 -> \"Three hundred fifty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 359 -> \"Three hundred fifty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 35 -> \"Thirty five\""); 
                                        } break;

                                    case '6':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 360 -> \"Three hundred sixty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 361 -> \"Three hundred sixty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 362 -> \"Three hundred sixty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 363 -> \"Three hundred sixty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 364 -> \"Three hundred sixty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 365 -> \"Three hundred sixty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 366 -> \"Three hundred sixty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 367 -> \"Three hundred sixty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 368 -> \"Three hundred sixty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 369 -> \"Three hundred sixty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 36 -> \"Thirty six\"");
                                         } break;

                                    case '7':
                                        if (str.Length == 3)
                                        {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 370 -> \"Three hundred seventy\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 371 -> \"Three hundred seventy one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 372 -> \"Three hundred seventy two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 373 -> \"Three hundred seventy three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 374 -> \"Three hundred seventy four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 375 -> \"Three hundred seventy five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 376 -> \"Three hundred seventy six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 377 -> \"Three hundred seventy seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 378 -> \"Three hundred seventy eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 379 -> \"Three hundred seventy nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 37 -> \"Thirty seven\"");
                                         } break;

                                    case '8':
                                         if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 380 -> \"Three hundred eighty\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 381 -> \"Three hundred eighty one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 382 -> \"Three hundred eighty two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 383 -> \"Three hundred eighty three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 384 -> \"Three hundred eighty four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 385 -> \"Three hundred eighty five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 386 -> \"Three hundred eighty six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 387 -> \"Three hundred eighty seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 388 -> \"Three hundred eighty eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 389 -> \"Three hundred eighty nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 38 -> \"Thirty eight\"");
                                        } break;

                                    case '9': 
                                        if (str.Length == 3)
                                         {
                                            char thirdDigit = str[2];

                                            switch (thirdDigit)
                                            {
                                                case '0': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 390 -> \"Three hundred ninety\""); break;
                                                case '1': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 391 -> \"Three hundred ninety one\""); break;
                                                case '2': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 392 -> \"Three hundred ninety two\""); break;
                                                case '3': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 393 -> \"Three hundred ninety three\""); break;
                                                case '4': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 394 -> \"Three hundred ninety four\""); break;
                                                case '5': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 395 -> \"Three hundred ninety five\""); break;
                                                case '6': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 396 -> \"Three hundred ninety six\""); break;
                                                case '7': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 397 -> \"Three hundred ninety seven\""); break;
                                                case '8': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 398 -> \"Three hundred ninety eight\""); break;
                                                case '9': 
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: 399 -> \"Three hundred ninety nine\""); break;
                                            }

                                        }
                                        else
                                        {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: 39 -> \"Thirty nine\"");
                                        } break;
                                }
                            }
                        } break;
            case '4': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 4 -> \"Four\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 4;
                                    string fourStr = "Four", fourtyStr = "Fourty";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
            case '5': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 5 -> \"Five\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 5;
                                    string fourStr = "Five", fourtyStr = "Fifty";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
            case '6': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 6 -> \"Six\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 6;
                                    string fourStr = "Six", fourtyStr = "Sixty";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
            case '7': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 7 -> \"Seven\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 7;
                                    string fourStr = "Seven", fourtyStr = "Seventy";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
            case '8': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 8 -> \"Eight\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 8;
                                    string fourStr = "Eight", fourtyStr = "Eighty";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
            case '9': 
                        if(str.Length == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" The number is: 9 -> \"Nine\""); break;
                        }
                        else 
                        {
                            if ((str.Length == 2) || (str.Length == 3))
                            {
                                char secondDigit = str[1];
                                char ch = '0';
                                
                                for ( ch = '0'; ch < '1'; ch++)
                                {
                                    int four = 9;
                                    string fourStr = "Nine", fourtyStr = "Ninety";
                                                       
                                    switch (secondDigit)
                                    {
                                        case '0':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];
                                            
                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}00 -> \"{1} hundred\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}01 -> \"{1} hundred and one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}02 -> \"{1} hundred and two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}03 -> \"{1} hundred and three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}04 -> \"{1} hundred and four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}05 -> \"{1} hundred and five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}06 -> \"{1} hundred and six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}07 -> \"{1} hundred and seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}08 -> \"{1} hundred and eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}09 -> \"{1} hundred and nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(" The number is: {0}0 -> \"{1}\"", four, fourtyStr); 
                                            } break;

                                        case '1':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}10 -> \"{1} hundred and ten\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}11 -> \"{1} hundred and eleven\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}12 -> \"{1} hundred and twelve\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}13 -> \"{1} hundred and tirteen\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}14 -> \"{1} hundred and fourteen\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}15 -> \"{1} hundred and fifteen\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}16 -> \"{1} hundred and sixteen\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}17 -> \"{1} hundred and seventeen\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}18 -> \"{1} hundred and eighteen\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}19 -> \"{1} hundred and nineteen\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}1 -> \"{1} one\"", four, fourtyStr); 
                                            } break;
                                        case '2':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}20 -> \"{1} hundred twenty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}21 -> \"{1} hundred twenty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}22 -> \"{1} hundred twenty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}23 -> \"{1} hundred twenty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}24 -> \"{1} hundred twenty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}25 -> \"{1} hundred twenty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}26 -> \"{1} hundred twenty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}27 -> \"{1} hundred twenty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}28 -> \"{1} hundred twenty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}29 -> \"{1} hundred twenty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}2 -> \"{1} two\"", four, fourtyStr); 
                                            } break;

                                        case '3': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}30 -> \"{1} hundred thirty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}31 -> \"{1} hundred thirty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}32 -> \"{1} hundred thirty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}33 -> \"{1} hundred thirty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}34 -> \"{1} hundred thirty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}35 -> \"{1} hundred thirty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}36 -> \"{1} hundred thirty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}37 -> \"{1} hundred thirty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}38 -> \"{1} hundred thirty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}39 -> \"{1} hundred thirty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}3 -> \"{1} three\"", four, fourtyStr); 
                                            } break;

                                        case '4':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}40 -> \"{1} hundred forty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}41 -> \"{1} hundred forty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}42 -> \"{1} hundred forty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}43 -> \"{1} hundred forty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}44 -> \"{1} hundred forty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}45 -> \"{1} hundred forty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}46 -> \"{1} hundred forty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}47 -> \"{1} hundred forty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}48 -> \"{1} hundred forty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}49 -> \"{1} hundred forty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}4 -> \"{1} four\"", four, fourtyStr); 
                                            } break;

                                        case '5': 
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}50 -> \"{1} hundred fifty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}51 -> \"{1} hundred fifty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}52 -> \"{1} hundred fifty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}53 -> \"{1} hundred fifty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}54 -> \"{1} hundred fifty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}55 -> \"{1} hundred fifty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}56 -> \"{1} hundred fifty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}57 -> \"{1} hundred fifty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}58 -> \"{1} hundred fifty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}59 -> \"{1} hundred fifty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}5 -> \"{1} five\"", four, fourtyStr); 
                                            } break;

                                        case '6':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}60 -> \"{1} hundred sixty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}61 -> \"{1} hundred sixty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}62 -> \"{1} hundred sixty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}63 -> \"{1} hundred sixty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}64 -> \"{1} hundred sixty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}65 -> \"{1} hundred sixty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}66 -> \"{1} hundred sixty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}67 -> \"{1} hundred sixty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}68 -> \"{1} hundred sixty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}69 -> \"{1} hundred sixty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}6 -> \"{1} six\"", four, fourtyStr);
                                             } break;

                                        case '7':
                                            if (str.Length == 3)
                                            {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}70 -> \"{1} hundred seventy\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}71 -> \"{1} hundred seventy one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}72 -> \"{1} hundred seventy two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}73 -> \"{1} hundred seventy three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}374 -> \"{1} hundred seventy four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}75 -> \"{1} hundred seventy five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}76 -> \"{1} hundred seventy six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}77 -> \"{1} hundred seventy seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}78 -> \"{1} hundred seventy eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}79 -> \"{1} hundred seventy nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}7 -> \"{1} seven\"", four, fourtyStr);
                                             } break;

                                        case '8':
                                             if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}80 -> \"{1} hundred eighty\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}81 -> \"{1} hundred eighty one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}82 -> \"{1} hundred eighty two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}83 -> \"{1} hundred eighty three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}84 -> \"{1} hundred eighty four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}85 -> \"{1} hundred eighty five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}86 -> \"{1} hundred eighty six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}87 -> \"{1} hundred eighty seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}88 -> \"{1} hundred eighty eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}89 -> \"{1} hundred eighty nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}8 -> \"{1} eight\"", four, fourtyStr);
                                            } break;

                                        case '9': 
                                            if (str.Length == 3)
                                             {
                                                char thirdDigit = str[2];

                                                switch (thirdDigit)
                                                {
                                                    case '0': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}90 -> \"{1} hundred ninety\"", four, fourStr); break;
                                                    case '1': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}91 -> \"{1} hundred ninety one\"", four, fourStr); break;
                                                    case '2': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}92 -> \"{1} hundred ninety two\"", four, fourStr); break;
                                                    case '3': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}93 -> \"{1} hundred ninety three\"", four, fourStr); break;
                                                    case '4': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}94 -> \"{1} hundred ninety four\"", four, fourStr); break;
                                                    case '5': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}95 -> \"{1} hundred ninety five\"", four, fourStr); break;
                                                    case '6': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}96 -> \"{1} hundred ninety six\"", four, fourStr); break;
                                                    case '7': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}97 -> \"{1} hundred ninety seven\"", four, fourStr); break;
                                                    case '8': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}98 -> \"{1} hundred ninety eight\"", four, fourStr); break;
                                                    case '9': 
                                                        Console.WriteLine();
                                                        Console.WriteLine(" The number is: {0}99 -> \"{1} hundred ninety nine\"", four, fourStr); break;
                                                }

                                            }
                                            else
                                            {
                                                    Console.WriteLine();
                                                    Console.WriteLine(" The number is: {0}9 -> \"{1} nine\"", four, fourtyStr);
                                            } break;
                                    }
                                }
                            }
                        } break;
        }
    }
}

                        

