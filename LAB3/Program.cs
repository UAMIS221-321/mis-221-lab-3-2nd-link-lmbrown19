
//main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStaduimReccomendation(enjoymentLevel);
string game = GetGameReccomendation(stadium);
DisplayStadiumDetails(stadium , game);
//end main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What is your preferred enjoyment level?\n Boring \n Average \n Fun \n Epic");
    System.Console.WriteLine("Enter 1 for boring, 2 for Average, 3 for Fun, 4 for Epic");
    return (Console.ReadLine());
}

static string GetStaduimReccomendation(string enjoymentLevel){
    if(enjoymentLevel == "1"){
        return "Neyland stadium";
    }
    else if(enjoymentLevel == "2"){
        return "Jordan-Hare Stadium";   
    }
    else if(enjoymentLevel == "3"){
        return "Tiger Stadium";    
    }
    else if(enjoymentLevel == "4"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "INVALID INPUT";
    }
}

static string GetGameReccomendation(string stadium){
    if(stadium == "Neyland stadium"){
        return "Tennesse vs Kent state";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        return "Auburn vs Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        return "LSU vs Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "Alabama vs Auburn";
    }
    else{
        return "INVALID";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    Console.Clear();
    System.Console.WriteLine($"We reccomend you go to {stadium} to watch {game}");
}

