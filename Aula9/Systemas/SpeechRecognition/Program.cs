﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognition
{
    class Program
    {
        //static void Main(string[] args)
        //{
            
        //    // Create an in-process speech recognizer for the en-US locale.  
        //    using (SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new CultureInfo("pt-BR")))
        //    {
                

        //        // Create and load a dictation grammar.  
        //        recognizer.LoadGrammar(new DictationGrammar());

        //        // Add a handler for the speech recognized event.  
        //        recognizer.SpeechRecognized +=
        //          new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

        //        // Configure input to the speech recognizer.  
        //        recognizer.SetInputToDefaultAudioDevice();

        //        // Start asynchronous, continuous speech recognition.  
        //        recognizer.RecognizeAsync(RecognizeMode.Multiple);

        //        // Keep the console window open.  
        //        while (true)
        //        {
        //            Console.ReadLine();
        //        }
        //    }
        //}
        //// Handle the SpeechRecognized event.  
        //static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    Console.WriteLine("Recognized text: " + e.Result.Text);
        //}
    }

}
