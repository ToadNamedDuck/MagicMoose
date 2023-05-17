using System;
using System.Collections.Generic;

void Main(){

    List<string> mooseAnswers = new List<string>();
     mooseAnswers.Add("As I see it, yes.");
     mooseAnswers.Add("Ask again later.");
     mooseAnswers.Add("Better to not tell you, now.");
     mooseAnswers.Add("That is for your actions to decide.");
     mooseAnswers.Add("Concentrate wholly and ask again.");
     mooseAnswers.Add("Don't count on it.");
     mooseAnswers.Add("It is most certain.");
     mooseAnswers.Add("Decidedly so, yes...");
     mooseAnswers.Add("It is most likely to be so.");
     mooseAnswers.Add("My reply is no.");
     mooseAnswers.Add("My sources say no.");
     mooseAnswers.Add("The outlook is grim.");
     mooseAnswers.Add("The outlook is positive this day.");
     mooseAnswers.Add("The spirits are mumbling, ask again and they may speak clearly.");
     mooseAnswers.Add("Signs point to yes.");
     mooseAnswers.Add("It is very doubtful.");
     mooseAnswers.Add("Without a doubt.");
     mooseAnswers.Add("Yes.");
     mooseAnswers.Add("Yes - absolutely!");
     mooseAnswers.Add("Rely on it!");

    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("_____________________________________");
    MooseSays("Ask me a question, and I shall answer thee!");

    while(WaitForResponse() != ""){
        MooseSays(MooseAnswer(mooseAnswers));
    }

    MooseSays("See you next time!");
}
Main();


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


string MooseAnswer(List<string> answers){
    Random random = new Random();
    int answerIndex = random.Next(0, 20);

    return answers[answerIndex];
}

string WaitForResponse(){
    Console.Write("Enter your question: ");
    var question = Console.ReadLine();
    if(question != ""){
        Console.Clear();
        Console.WriteLine(question);
        return question;
    }
    else return "";
}