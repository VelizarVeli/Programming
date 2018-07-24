namespace _02.Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>(); //CREATE A LIST OF STRINGS TO HOLD OUR MESSAGES
            List<string> broadcasts = new List<string>(); //CREATE A LIST OF STRINGS TO HOLD OUR BROADCASTS

            //CREATE TWO REGEX PATTERNS TO MATCH THE TWO TYPES OF QUERIES
            //THE PATTERNS ARE ALMOST IDENTICAL
            //THE MESSAGE ONE IS WITH (\d) BECAUSE IT WANTS ONLY DIGITS ON THE FIRST QUERY
            //THE BROADCAST ONE IS WITH (\D) BECAUSE IT WANTS EVERYTHING BUT DIGITS ON THE FIRST QUERY
            //THE SECOND QUERY IS THE SAME FOR BOTH CASES
            string messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$"; //WE USE REGEX GROUPS 
            string broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$"; //SO WE CAN EXTRACT THE INFORMATION EASIER

            //INITIALIZE THE 2 REGEX VARIABLES
            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            //READ THE FIRST INPUT LINE
            string inputLine = Console.ReadLine();

            //CREATE A WHILE LOOP THAT READS TILL YOU REACH THE END COMMAND
            while (inputLine != "Hornet is Green")
            {
                //IF THE MESSAGE REGEX MATCHES DO THE MESSAGE LOGIC
                if (messageRegex.IsMatch(inputLine))
                {
                    //TAKE THE MATCH WITH THE REGEX
                    Match match = messageRegex.Match(inputLine);

                    //NOTICE HOW WE USE THE GROUPS FROM THE REGEX TO EXTRACT THE 2 QUERIES
                    //TAKE THE FIRST QUERY, REVERSE THE STRING => IT TURNS INTO A COLLECTION OF CHARACTER "char"
                    //THEN STRING JOIN IT BY NOTHING "", AND IT TURNS INTO A STRING (CLEVER EYH)
                    string recipientCode = string.Join("", match.Groups[1].Value.Reverse());

                    string message = match.Groups[2].Value; //TAKE THE MESSAGE

                    //FORM A STRING (FIRST QUERY) -> (SECOND QUERY)
                    //ADD IT TO THE LIST OF MESSAGES
                    messages.Add(recipientCode + " -> " + message);
                }

                //IF THE BROADCAST REGEX MATCHES DO THE BROADCAST LOGIC
                if (broadcastRegex.IsMatch(inputLine))
                {
                    //TAKE THE MATCH WITH THE REGEX
                    Match match = broadcastRegex.Match(inputLine);

                    string message = match.Groups[1].Value; //TAKE THE MESSAGE

                    //TAKE THE FREQUENCY AND DECRYPT IT WITH A METHOD
                    string frequency = DecryptFrequency(match.Groups[2].Value);

                    //FORM A STRING (SECOND QUERY) -> (FIRST QUERY)
                    //ADD IT TO THE LIST OF BROADCASTS
                    broadcasts.Add(frequency + " -> " + message);
                }

                //READ THE NEXT INPUT LINE
                inputLine = Console.ReadLine();
            }

            //PRINT BROADCASTS
            Console.WriteLine("Broadcasts:");

            //IF THERE ARE ANY BROADCASTS PRINT THEM JOINED BY "\n" (NEW LINE)
            //ELSE, PRINT "None"
            if (broadcasts.Count > 0)
            {
                Console.WriteLine(string.Join("\n", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            //THE COOL WAY - WITH LINQ AND TERNARY OPERATOR
            //Console.WriteLine(broadcasts.Any() ? string.Join("\n", broadcasts) : "None");

            //PRINT MESSAGES
            Console.WriteLine("Messages:");

            //IF THERE ARE ANY MESSAGES PRINT THEM JOINED BY "\n" (NEW LINE)
            //ELSE, PRINT "None"
            if (messages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", messages));
            }
            else
            {
                Console.WriteLine("None");
            }

            //THE COOL WAY - WITH LINQ AND TERNARY OPERATOR
            //Console.WriteLine(messages.Any() ? string.Join("\n", messages) : "None");
        }

        //METHOD FOR DECRYPTING THE FREQUENCY
        //TAKES EVERY CHARACTER FROM A GIVEN STRING
        //APPENDS IT TO ANOTHER STRING
        //IF THE CHARACTER IS A UPPERCASE LETTER => TRANSFORMS IT INTO A LOWERCASE LETTER BEFORE APPENDING IT
        //IF THE CHARACTER IS A LOWERCASE LETTER => TRANSFORMS IT INTO AN UPPERCASE LETTER BEFORE APPENDING IT
        private static string DecryptFrequency(string encryptedFrequency)
        {
            //THE RESULT STRING
            string decryptedFrequency = "";

            //THE FOREACH THAT PASSES TROUGH ALL CHARACTERS
            foreach (char currentChar in encryptedFrequency)
            {
                //IF ITS AN UPPERCASE LETTER, MAKE IT A LOWERCASE
                //IF ITS A LOWERCASE LETTER, MAKE IT AN UPPERCASE
                //ELSE, JUST APPEND IT
                if (currentChar >= 65 && currentChar <= 90)
                {
                    decryptedFrequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    decryptedFrequency += (char)(currentChar - 32);
                }
                else
                {
                    decryptedFrequency += currentChar;
                }
            }

            //RETURN THE RESULT STRING
            return decryptedFrequency;
        }
    }
}

//MUST BE WHOLE SENTENCE (^$)
//BROADCAST / MESSAGE
//
//MESSAGE - ONE WITH DIGITS / MESSAGE
//BROADCAST - ONE WITH MESSAGE / DIGITS
//
//MESSAGE - DIGITS ONLY - THE RECIPENT'S CODE / LETTERS AND DIGITS - THE MESSAGE
//BROADCAST - LETTERS AND DIGITS - THE MESSAGE / DIGITS AND LETTERS - THE FREQUENCY
//
//RECIPENT'S CODE - REVERSED
//FREQUENCY - ALL UPPERCASE LETTERS - TO LOWERCASE, ALL LOWERCASE LETTERS - TO UPPERCASE
//
//PRINTED BROADCASTS
//{FREQUENCY} -> {MESSAGE}
//PRINTED MESSAGES
//{RECIPENT} ~ {MESSAGE}