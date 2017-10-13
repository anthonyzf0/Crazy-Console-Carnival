using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses
{
    class Question
    {
        public String question;
        public String[] answers;
        public int correctAnswer;

        public int category;
        public int level;
        // public int x;

        public Question(int category, int level, String q, String[] a, int correct)
        {
            this.category = category;
            this.question = q;
            this.level = level;
            // this.x = x;

            this.answers = a;
            this.correctAnswer = correct;
        }
    }
}

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{

    class TriviaMania : CarnivalGame
    {
        private List<Question> questions = new List<Question>();

        public TriviaMania() : base()
        {
            //this.questions = new List<Question>();

            // questions go here

            // movies

            this.questions.Add(new Question(1, 1, "Little Cuba is the nickname of which US city?",                                                                                                new String[] { "[A] the one with the weed problem", "[B] the one with the shooting problem", "[C] the one with the loud music", "[D] the one with the heroine problem" }, 1));
            this.questions.Add(new Question(1, 1, "Who was the first US President to declare war?",                                                                                               new String[] { "[A] the one who named their penis Jerry", "[B] the one that got stuck in a bathtub", "[C] the black one", "[D] the one who bombed like ... everyone" }, 2));
            this.questions.Add(new Question(1, 1, "How many people have walked on the moon?",                                                                                                     new String[] { "[A] 4", "[B] a fuck ton we have whole societies there", "[C] no one it was staged", "[D] didn't they blow up or some shit" }, 3));
            this.questions.Add(new Question(1, 1, "How many stripes are on the American flag?",                                                                                                   new String[] { "[A] one for every state", "[B] one for ever person killed by police brutality", "[C] one for every president", "[C] one for every year this country built itself upon taken land and abused peoples" }, 4));
            this.questions.Add(new Question(1, 1, "Who was the first man to set foot on the moon?",                                                                                               new String[] { "[A] we've been over this", "[B] like 232,437,436 people ", "[C] because we have bases", "[D] wake up you fuckin swine" }, 2));
            this.questions.Add(new Question(1, 1, "In what year did India gain its independence from Britain?",                                                                                   new String[] { "[A] they didn't", "[B] too late", "[C] too early", "[D] those towelheads should've never gained independance from Mother Britain" }, 3));
            this.questions.Add(new Question(1, 1, "In the movie \" The Wizard of Oz\", what did the Scarecrow want from the wizard?",                                                             new String[] { "[A] a heart", "[B] a brain", "[C] courage", "[D] some succ" }, 1));
            this.questions.Add(new Question(1, 1, "Who does th evoiceover for Dory in \"Finding Nemo\"?",                                                                                         new String[] { "[A] that gay celebrity", "[B] Canada", "[C] an actual bear", "[D] Maddie" }, 2));
            this.questions.Add(new Question(1, 1, "In what year was the original \"Jurassic Park\" film released?",                                                                               new String[] { "[A] 23867", "[B] 414", "[C] 1993", "[D] 2398" }, 3));
            this.questions.Add(new Question(1, 1, "Who was the French scultpor who made the Sttue of Liberty?",                                                                                   new String[] { "[A] a cigarette butt", "[B] a half eaten bagette", "[C] Daft Punk", "[D] a croissant soaked in sewage" }, 1));
            this.questions.Add(new Question(1, 1, "What is the main color of the Chinese flag?",                                                                                                  new String[] { "[A] blood orange", "[B] yeast infection color", "[C] the color of that pimple that's been there since 2004", "[D] Satan's urethra red " }, 4));
            this.questions.Add(new Question(1, 1, "What was the name of the whale in the 1993 movie, \"Free Willy\"?",                                                                            new String[] { "[A] Suni", "[B] Bobbi", "[C] Pickle", "[D] Keiko" }, 4));
            this.questions.Add(new Question(1, 1, "what is a fear of disease?",                                                                                                                   new String[] { "[A] acrophobia", "[B] sickophobuia", "[C] common sense", "[D] eh idk hwaever the fukc" }, 2));
            this.questions.Add(new Question(1, 1, "",                                                                                                                                             new String[] { "[A]", "[B]", "[C]", "[D]" }, 3));
            this.questions.Add(new Question(1, 1, "Why are flamingos pink?",                                                                                                                      new String[] { "[A] gay", "[B] gaay", "[C] gaaay", "[D] gaaaay" }, 1));
            this.questions.Add(new Question(1, 1, "What is America's national animal?",                                                                                                           new String[] { "[A] yor drunk uncle at the Fourth of July cook-out", "[B] an eagle's beak", "[C] the turkey balls", "[D]a pizza taco deep fried " }, 1));
            this.questions.Add(new Question(1, 1, "Infamous English prisoner, Charels Bronson, was played by what actor in the 2008 film \"Bronson\"?",                                           new String[] { "[A] your dad's jizz sock that you were supposed to land in", "[B] you were an unplanned pregnancy", "[C] your mom wanted to abort you but was afraid your father would leave", "[D] sorry you had to find ou this way" }, 2));
            this.questions.Add(new Question(1, 1, "What is the fear of choking?",                                                                                                                 new String[] { "[A] catophobia", "[B] holy shit i cant breathe", "[C] no body likes being choked", "[D] please respect all kinks" }, 3));
            this.questions.Add(new Question(1, 1, "What kind of person shall not be honored on a US postal stamp, according to the US postal service and the Citizen's Stamp Advisory Commitee?", new String[] { "[A] Hitler", "[B] Sudam Hussain", "[C] Osama Bin-Ladin", "[D] James Charles" }, 4));
            this.questions.Add(new Question(1, 1, "The average human body contains how many pints of blood?",                                                                                     new String[] { "[A] a shit ton", "[B] a fuck ton", "[C] a butt ton", "[D] about this much" }, 1));
            this.questions.Add(new Question(1, 1, "Which of the planets is closest to the sun?",                                                                                                  new String[] { "[A] the big one", "[B] the sideways one", "[C] the red one", "[D] the pne we're on" }, 2));
            this.questions.Add(new Question(1, 1, "In the movie Mean Girls, where is Caty originally from?",                                                                                      new String[] { "[A] an anus", "[B] where all those starving kid commercials are filmed", "[C] Switzerland", "[D] Kentucky", }, 2));
            this.questions.Add(new Question(1, 1, "What is a fear of dogs?",                                                                                                                      new String[] { "[A] but they bite", "[B] fucking bullshite", "[C] i got bit by a dog once", "[D] cats tho" }, 2));
            this.questions.Add(new Question(1, 1, "How is the groundnut better known?",                                                                                                           new String[] { "[A] you missed the sock", "[B] they specifically told you to", "[C] I already have an odd stain there so oh well", "[D] fuck too early ... again" }, 3));
            this.questions.Add(new Question(1, 1, "In the sport of Judo, what color belt follows an orange belt?",                                                                                new String[] { "[A] marrige iguana green", "[B] void of depression and self doubt black", "[C] that cumstain on your carpet color", "[D] the color of that weird bump on your taint with the hair coming out of it" }, 4));
            this.questions.Add(new Question(1, 1, "What is the most commonly diagnosed cancer in men?",                                                                                           new String[] { "[A] prostate", "[B] urethra", "[C] testicle", "[D] toe" }, 1));

            this.questions.Add(new Question(1, 2, "What was the name of the whale in the 1993 movie, \"Free Willy\"?",                                                                            new String[] { "[A] Suni", "[B] Bobbi", "[C] Pickle", "[D] Keiko" }, 4));
            this.questions.Add(new Question(1, 2, "what is a fear of disease?",                                                                                                                   new String[] { "[A] acrophobia", "[B] sickophobuia", "[C] common sense", "[D] eh idk hwaever the fukc" }, 2));
            this.questions.Add(new Question(1, 2, "",                                                                                                                                             new String[] { "[A]", "[B]", "[C]", "[D]" }, 3));
            this.questions.Add(new Question(1, 2, "Why are flamingos pink?",                                                                                                                      new String[] { "[A] gay", "[B] gaay", "[C] gaaay", "[D] gaaaay"}, 1));
            this.questions.Add(new Question(1, 2, "What is America's national animal?",                                                                                                           new String[] { "[A] yor drunk uncle at the Fourth of July cook-out", "[B] an eagle's beak", "[C] the turkey balls", "[D]a pizza taco deep fried " }, 1));
            this.questions.Add(new Question(1, 2, "In the movie \" The Wizard of Oz\", what did the Scarecrow want from the wizard?",                                                             new String[] { "[A] a heart", "[B] a brain", "[C] courage", "[D] some succ" }, 1));
            this.questions.Add(new Question(1, 2, "Who does th evoiceover for Dory in \"Finding Nemo\"?",                                                                                         new String[] { "[A] that gay celebrity", "[B] Canada", "[C] an actual bear", "[D] Maddie" }, 2));
            this.questions.Add(new Question(1, 2, "In what year was the original \"Jurassic Park\" film released?",                                                                               new String[] { "[A] 23867", "[B] 414", "[C] 1993", "[D] 2398" }, 3));
            this.questions.Add(new Question(1, 2, "Who was the French scultpor who made the Sttue of Liberty?",                                                                                   new String[] { "[A] a cigarette butt", "[B] a half eaten bagette", "[C] Daft Punk", "[D] a croissant soaked in sewage" }, 1));
            this.questions.Add(new Question(1, 2, "What is the main color of the Chinese flag?",                                                                                                  new String[] { "[A] blood orange", "[B] yeast infection color", "[C] the color of that pimple that's been there since 2004", "[D] Satan's urethra red " }, 4));
            this.questions.Add(new Question(1, 2, "Infamous English prisoner, Charels Bronson, was played by what actor in the 2008 film \"Bronson\"?",                                           new String[] { "[A] your dad's jizz sock that you were supposed to land in", "[B] you were an unplanned pregnancy", "[C] your mom wanted to abort you but was afraid your father would leave", "[D] sorry you had to find ou this way" }, 2));
            this.questions.Add(new Question(1, 2, "What is the fear of choking?",                                                                                                                 new String[] { "[A] catophobia", "[B] holy shit i cant breathe", "[C] no body likes being choked", "[D] please respect all kinks" }, 3));
            this.questions.Add(new Question(1, 2, "What kind of person shall not be honored on a US postal stamp, according to the US postal service and the Citizen's Stamp Advisory Commitee?", new String[] { "[A] Hitler", "[B] Sudam Hussain", "[C] Osama Bin-Ladin", "[D] James Charles" }, 4));
            this.questions.Add(new Question(1, 2, "The average human body contains how many pints of blood?",                                                                                     new String[] { "[A] a shit ton", "[B] a fuck ton", "[C] a butt ton", "[D] about this much" }, 1));
            this.questions.Add(new Question(1, 2, "Which of the planets is closest to the sun?",                                                                                                  new String[] { "[A] the big one", "[B] the sideways one", "[C] the red one", "[D] the pne we're on" }, 2));
            this.questions.Add(new Question(1, 2, "In the movie Mean Girls, where is Caty originally from?",                                                                                      new String[] { "[A] an anus", "[B] where all those starving kid commercials are filmed", "[C] Switzerland", "[D] Kentucky", }, 2));
            this.questions.Add(new Question(1, 2, "What is a fear of dogs?",                                                                                                                      new String[] { "[A] but they bite", "[B] fucking bullshite", "[C] i got bit by a dog once", "[D] cats tho" }, 2));
            this.questions.Add(new Question(1, 2, "How is the groundnut better known?",                                                                                                           new String[] { "[A] you missed the sock", "[B] they specifically told you to", "[C] I already have an odd stain there so oh well", "[D] fuck too early ... again" }, 3));
            this.questions.Add(new Question(1, 2, "In the sport of Judo, what color belt follows an orange belt?",                                                                                new String[] { "[A] marrige iguana green", "[B] void of depression and self doubt black", "[C] that cumstain on your carpet color", "[D] the color of that weird bump on your taint with the hair coming out of it" }, 4));
            this.questions.Add(new Question(1, 2, "Little Cuba is the nickname of which US city?", new String[] { "[A] the one with the weed problem", "[B] the one with the shooting problem", "[C] the one with the loud music", "[D] the one with the heroine problem" }, 1));
            this.questions.Add(new Question(1, 2, "Who was the first US President to declare war?", new String[] { "[A] the one who named their penis Jerry", "[B] the one that got stuck in a bathtub", "[C] the black one", "[D] the one who bombed like ... everyone" }, 2));
            this.questions.Add(new Question(1, 2, "How many people have walked on the moon?", new String[] { "[A] 4", "[B] a fuck ton we have whole societies there", "[C] no one it was staged", "[D] didn't they blow up or some shit" }, 3));
            this.questions.Add(new Question(1, 2, "How many stripes are on the American flag?", new String[] { "[A] one for every state", "[B] one for ever person killed by police brutality", "[C] one for every president", "[C] one for every year this country built itself upon taken land and abused peoples" }, 4));
            this.questions.Add(new Question(1, 2, "Who was the first man to set foot on the moon?", new String[] { "[A] we've been over this", "[B] like 232,437,436 people ", "[C] because we have bases", "[D] wake up you fuckin swine" }, 2));
            this.questions.Add(new Question(1, 2, "In what year did India gain its independence from Britain?", new String[] { "[A] they didn't", "[B] too late", "[C] too early", "[D] those towelheads should've never gained independance from Mother Britain" }, 3));
            this.questions.Add(new Question(1, 2, "What is the most commonly diagnosed cancer in men?",                                                                                           new String[] { "[A] prostate", "[B] urethra", "[C] testicle", "[D] toe" }, 1));

            this.questions.Add(new Question(1, 3, "Infamous English prisoner, Charels Bronson, was played by what actor in the 2008 film \"Bronson\"?",                                           new String[] { "[A] your dad's jizz sock that you were supposed to land in", "[B] you were an unplanned pregnancy", "[C] your mom wanted to abort you but was afraid your father would leave", "[D] sorry you had to find ou this way" }, 2));
            this.questions.Add(new Question(1, 3, "What is the fear of choking?",                                                                                                                 new String[] { "[A] catophobia", "[B] holy shit i cant breathe", "[C] no body likes being choked", "[D] please respect all kinks" }, 3));
            this.questions.Add(new Question(1, 3, "What kind of person shall not be honored on a US postal stamp, according to the US postal service and the Citizen's Stamp Advisory Commitee?", new String[] { "[A] Hitler", "[B] Sudam Hussain", "[C] Osama Bin-Ladin", "[D] James Charles" }, 4));
            this.questions.Add(new Question(1, 3, "The average human body contains how many pints of blood?",                                                                                     new String[] { "[A] a shit ton", "[B] a fuck ton", "[C] a butt ton", "[D] about this much" }, 1));
            this.questions.Add(new Question(1, 3, "Which of the planets is closest to the sun?",                                                                                                  new String[] { "[A] the big one", "[B] the sideways one", "[C] the red one", "[D] the pne we're on" }, 2));
            this.questions.Add(new Question(1, 3, "What was the name of the whale in the 1993 movie, \"Free Willy\"?",                                                                            new String[] { "[A] Suni", "[B] Bobbi", "[C] Pickle", "[D] Keiko" }, 4));
            this.questions.Add(new Question(1, 3, "what is a fear of disease?",                                                                                                                   new String[] { "[A] acrophobia", "[B] sickophobuia", "[C] common sense", "[D] eh idk hwaever the fukc" }, 2));
            this.questions.Add(new Question(1, 3, "",                                                                                                                                             new String[] { "[A]", "[B]", "[C]", "[D]" }, 3));
            this.questions.Add(new Question(1, 3, "Why are flamingos pink?",                                                                                                                      new String[] { "[A] gay", "[B] gaay", "[C] gaaay", "[D] gaaaay" }, 1));
            this.questions.Add(new Question(1, 3, "What is America's national animal?",                                                                                                           new String[] { "[A] yor drunk uncle at the Fourth of July cook-out", "[B] an eagle's beak", "[C] the turkey balls", "[D]a pizza taco deep fried " }, 1));
            this.questions.Add(new Question(1, 3, "In the movie \" The Wizard of Oz\", what did the Scarecrow want from the wizard?",                                                             new String[] { "[A] a heart", "[B] a brain", "[C] courage", "[D] some succ" }, 1));
            this.questions.Add(new Question(1, 3, "Who does th evoiceover for Dory in \"Finding Nemo\"?",                                                                                         new String[] { "[A] that gay celebrity", "[B] Canada", "[C] an actual bear", "[D] Maddie" }, 2));
            this.questions.Add(new Question(1, 3, "In what year was the original \"Jurassic Park\" film released?",                                                                               new String[] { "[A] 23867", "[B] 414", "[C] 1993", "[D] 2398" }, 3));
            this.questions.Add(new Question(1, 3, "Who was the French scultpor who made the Sttue of Liberty?",                                                                                   new String[] { "[A] a cigarette butt", "[B] a half eaten bagette", "[C] Daft Punk", "[D] a croissant soaked in sewage" }, 1));
            this.questions.Add(new Question(1, 3, "What is the main color of the Chinese flag?",                                                                                                  new String[] { "[A] blood orange", "[B] yeast infection color", "[C] the color of that pimple that's been there since 2004", "[D] Satan's urethra red " }, 4));
            this.questions.Add(new Question(1, 3, "In the movie Mean Girls, where is Caty originally from?",                                                                                      new String[] { "[A] an anus", "[B] where all those starving kid commercials are filmed", "[C] Switzerland", "[D] Kentucky", }, 2));
            this.questions.Add(new Question(1, 3, "What is a fear of dogs?",                                                                                                                      new String[] { "[A] Ffucking bullshite", "[B] but they bite", "[C] i got bit by a dog once", "[D] cats tho" }, 2));
            this.questions.Add(new Question(1, 3, "How is the groundnut better known?",                                                                                                           new String[] { "[A] you missed the sock", "[B] they specifically told you to", "[C] I already have an odd stain there so oh well", "[D] fuck too early ... again" }, 3));
            this.questions.Add(new Question(1, 3, "Little Cuba is the nickname of which US city?", new String[] { "[A] the one with the weed problem", "[B] the one with the shooting problem", "[C] the one with the loud music", "[D] the one with the heroine problem" }, 1));
            this.questions.Add(new Question(1, 3, "Who was the first US President to declare war?", new String[] { "[A] the one who named their penis Jerry", "[B] the one that got stuck in a bathtub", "[C] the black one", "[D] the one who bombed like ... everyone" }, 2));
            this.questions.Add(new Question(1, 3, "How many people have walked on the moon?", new String[] { "[A] 4", "[B] a fuck ton we have whole societies there", "[C] no one it was staged", "[D] didn't they blow up or some shit" }, 3));
            this.questions.Add(new Question(1, 3, "How many stripes are on the American flag?", new String[] { "[A] one for every state", "[B] one for ever person killed by police brutality", "[C] one for every president", "[C] one for every year this country built itself upon taken land and abused peoples" }, 4));
            this.questions.Add(new Question(1, 3, "Who was the first man to set foot on the moon?", new String[] { "[A] we've been over this", "[B] like 232,437,436 people ", "[C] because we have bases", "[D] wake up you fuckin swine" }, 2));
            this.questions.Add(new Question(1, 3, "In what year did India gain its independence from Britain?", new String[] { "[A] they didn't", "[B] too late", "[C] too early", "[D] those towelheads should've never gained independance from Mother Britain" }, 3));
            this.questions.Add(new Question(1, 3, "In the sport of Judo, what color belt follows an orange belt?",                                                                                new String[] { "[A] marrige iguana green", "[B] void of depression and self doubt black", "[C] that cumstain on your carpet color", "[D] the color of that weird bump on your taint with the hair coming out of it" }, 4));
            this.questions.Add(new Question(1, 3, "What is the most commonly diagnosed cancer in men?",                                                                                           new String[] { "[A] prostate", "[B] urethra", "[C] testicle", "[D] toe" }, 1));

            this.questions.Add(new Question(1, 4, "In the movie Mean Girls, where is Caty originally from?",                                                                                      new String[] { "[A] an anus", "[B] where all those starving kid commercials are filmed", "[C] Switzerland", "[D] Kentucky", }, 2));
            this.questions.Add(new Question(1, 4, "What is a fear of dogs?",                                                                                                                      new String[] { "[A] but they bite", "[B] fucking bullshite", "[C] i got bit by a dog once", "[D] cats tho" }, 2));
            this.questions.Add(new Question(1, 4, "How is the groundnut better known?",                                                                                                           new String[] { "[A] you missed the sock", "[B] they specifically told you to", "[C] I already have an odd stain there so oh well", "[D] fuck too early ... again" }, 3));
            this.questions.Add(new Question(1, 4, "In the sport of Judo, what color belt follows an orange belt?",                                                                                new String[] { "[A] marrige iguana green", "[B] void of depression and self doubt black", "[C] that cumstain on your carpet color", "[D] the color of that weird bump on your taint with the hair coming out of it" }, 4));
            this.questions.Add(new Question(1, 4, "What is the most commonly diagnosed cancer in men?",                                                                                           new String[] { "[A] prostate", "[B] urethra", "[C] testicle", "[D] toe" }, 1));
            this.questions.Add(new Question(1, 4, "What was the name of the whale in the 1993 movie, \"Free Willy\"?",                                                                            new String[] { "[A] Suni", "[B] Bobbi", "[C] Pickle", "[D] Keiko" }, 4));
            this.questions.Add(new Question(1, 4, "what is a fear of disease?",                                                                                                                   new String[] { "[A] acrophobia", "[B] sickophobuia", "[C] common sense", "[D] eh idk hwaever the fukc" }, 2));
            this.questions.Add(new Question(1, 4, "",                                                                                                                                             new String[] { "[A]", "[B]", "[C]", "[D]" }, 3));
            this.questions.Add(new Question(1, 4, "Why are flamingos pink?",                                                                                                                      new String[] { "[A] gay", "[B] gaay", "[C] gaaay", "[D] gaaaay" }, 1));
            this.questions.Add(new Question(1, 4, "What is America's national animal?",                                                                                                           new String[] { "[A] yor drunk uncle at the Fourth of July cook-out", "[B] an eagle's beak", "[C] the turkey balls", "[D]a pizza taco deep fried " }, 1));
            this.questions.Add(new Question(1, 4, "In the movie \" The Wizard of Oz\", what did the Scarecrow want from the wizard?",                                                             new String[] { "[A] a heart", "[B] a brain", "[C] courage", "[D] some succ" }, 1));
            this.questions.Add(new Question(1, 4, "Who does th evoiceover for Dory in \"Finding Nemo\"?",                                                                                         new String[] { "[A] that gay celebrity", "[B] Canada", "[C] an actual bear", "[D] Maddie" }, 2));
            this.questions.Add(new Question(1, 4, "In what year was the original \"Jurassic Park\" film released?",                                                                               new String[] { "[A] 23867", "[B] 414", "[C] 1993", "[D] 2398" }, 3));
            this.questions.Add(new Question(1, 4, "Who was the French scultpor who made the Sttue of Liberty?",                                                                                   new String[] { "[A] a cigarette butt", "[B] a half eaten bagette", "[C] Daft Punk", "[D] a croissant soaked in sewage" }, 1));
            this.questions.Add(new Question(1, 4, "What is the main color of the Chinese flag?",                                                                                                  new String[] { "[A] blood orange", "[B] yeast infection color", "[C] the color of that pimple that's been there since 2004", "[D] Satan's urethra red " }, 4));
            this.questions.Add(new Question(1, 4, "Infamous English prisoner, Charels Bronson, was played by what actor in the 2008 film \"Bronson\"?",                                           new String[] { "[A] your dad's jizz sock that you were supposed to land in", "[B] you were an unplanned pregnancy", "[C] your mom wanted to abort you but was afraid your father would leave", "[D] sorry you had to find ou this way" }, 2));
            this.questions.Add(new Question(1, 4, "What is the fear of choking?",                                                                                                                 new String[] { "[A] catophobia", "[B] holy shit i cant breathe", "[C] no body likes being choked", "[D] please respect all kinks" }, 3));
            this.questions.Add(new Question(1, 4, "What kind of person shall not be honored on a US postal stamp, according to the US postal service and the Citizen's Stamp Advisory Commitee?", new String[] { "[A] Hitler", "[B] Sudam Hussain", "[C] Osama Bin-Ladin", "[D] James Charles" }, 4));
            this.questions.Add(new Question(1, 4, "The average human body contains how many pints of blood?",                                                                                     new String[] { "[A] a shit ton", "[B] a fuck ton", "[C] a butt ton", "[D] about this much" }, 1));
            this.questions.Add(new Question(1, 4, "Which of the planets is closest to the sun?",                                                                                                  new String[] { "[A] the big one", "[B] the sideways one", "[C] the red one", "[D] the pne we're on" }, 2));
            this.questions.Add(new Question(1, 4, "Little Cuba is the nickname of which US city?", new String[] { "[A] the one with the weed problem", "[B] the one with the shooting problem", "[C] the one with the loud music", "[D] the one with the heroine problem" }, 1));
            this.questions.Add(new Question(1, 4, "Who was the first US President to declare war?", new String[] { "[A] the one who named their penis Jerry", "[B] the one that got stuck in a bathtub", "[C] the black one", "[D] the one who bombed like ... everyone" }, 2));
            this.questions.Add(new Question(1, 4, "How many people have walked on the moon?", new String[] { "[A] 4", "[B] a fuck ton we have whole societies there", "[C] no one it was staged", "[D] didn't they blow up or some shit" }, 3));
            this.questions.Add(new Question(1, 4, "How many stripes are on the American flag?", new String[] { "[A] one for every state", "[B] one for ever person killed by police brutality", "[C] one for every president", "[C] one for every year this country built itself upon taken land and abused peoples" }, 4));
            this.questions.Add(new Question(1, 4, "Who was the first man to set foot on the moon?", new String[] { "[A] we've been over this", "[B] like 232,437,436 people ", "[C] because we have bases", "[D] wake up you fuckin swine" }, 2));
            this.questions.Add(new Question(1, 4, "In what year did India gain its independence from Britain?", new String[] { "[A] they didn't", "[B] too late", "[C] too early", "[D] those towelheads should've never gained independance from Mother Britain" }, 3));

        }

        public override string getName()
        { return "Trivia Mania"; }

        public override void play()
        {
            // CODE HERE
            List<String> names = new List<string>();

            // print name and promp user for name and available prizes
            writeLine(" Hello and welcome to Trivia Mania!!!");
            writeLine(" Get five questions in a row right and win the ~Grand Prize~ ");

            int playerNum = 1;

            while (true)
            {
                writeLine(" How many players will be participating this round?  ");

                // show choices of number of players 

                String input = getInput();

                if (int.TryParse(input, out playerNum))
                    break;
                else
                { writeLine("You must enter a number of players."); }
            }

            // number of players
            writeLine("What's your name?");

            for (int i = 0; i < playerNum; i++)
            {
                writeLine("Player " + (i + 1) + ": ");
                names.Add(getInput());
            }

            // ask category
            int categoryNum = 1;
            while (true)
            {
                writeLine("Which category would you like?: ");
                writeLine("[1] Movies");
                String category = getInput();

                if (int.TryParse(category, out categoryNum))
                {
                    if (categoryNum == 1)
                        break;}
                else
                { writeLine("You must choose one of the available categories"); }
            }

            // prompt user for category and level of difficulty
            int levelNum = 1;
            while (true)
            {
                writeLine("Which level of difficulty would you like?");
                writeLine("[1] Cake");
                writeLine("[2] Tough Shit");
                writeLine("[3] Hard as Balls");
                writeLine("[4] no");
                String level = getInput();

                if (int.TryParse(level, out levelNum))
                {
                    if (levelNum <= 4)
                    {break;}}
                   else
                      { writeLine("You must choose one of the available levels"); }

            }
            // random int
            

                Random rnd = new Random();

            List<Question> possible = this.questions.Where(n => n.category == categoryNum && n.level == levelNum).ToList();


            int qnum = 0;

            for (int i = 0; i < 300; i++)
            {
                qnum = rnd.Next(0, possible.Count - 1);
                Question q = possible[qnum];
                possible.RemoveAt(qnum);
                possible.Add(q);
            }


            qnum = 0;
            while (true)
            {

                Question q = possible[qnum];

                writeLine(q.question);

                foreach (String answer in q.answers)
                { writeLine(answer); }

                write("What is your answer? : ");
                String choice = getInput().ToUpper();
                int answerIndex = choice[0] - 'A';

                qnum++;
                if (qnum == possible.Count)
                    qnum = 0;
            } }}}
