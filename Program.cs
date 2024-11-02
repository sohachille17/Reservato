// See https://aka.ms/new-console-template for more information

bool LoopRum = true;
int nombreTotalReserver = 0;
int nombreTotalParticipant = 0;
int Participant;
string? Reserver;
string? VoulezVousContinuer;



do
{

    Console.WriteLine("Entrer le nombre de participants :");
    string? NombreParticipant = Console.ReadLine();
    int.TryParse(NombreParticipant, out int userPart);
    Participant = userPart;

    if(userPart >= 20 && userPart <= 50){
        Console.WriteLine(DeterminerLasalle(userPart, "Salle 2", 50));
        ContinueAreserver("Salle 2", 50);
        LoopRum = ArreterOuPas(); 
       

    }else if(userPart >= 100 && userPart <= 200 ){
        Console.WriteLine(DeterminerLasalle(userPart, "Salle 4", 200));
        ContinueAreserver("Salle 4", 200);
        LoopRum = ArreterOuPas(); 
        
    }else if(userPart >= 1 && userPart <= 20 ){
        Console.WriteLine(DeterminerLasalle(userPart, "Salle 1", 20));
        ContinueAreserver("Salle 1", 20);
        LoopRum = ArreterOuPas(); 
        
    }else if(userPart >= 50 && userPart <= 100 ){
        Console.WriteLine(DeterminerLasalle(userPart, "Salle 3", 100));
        ContinueAreserver("Salle 3", 100);
        LoopRum = ArreterOuPas(); 
       
    }else if(userPart >= 200 && userPart <= 500 ){
        Console.WriteLine(DeterminerLasalle(userPart, "Salle 5", 500));
        ContinueAreserver("Salle 5", 500);
        LoopRum = ArreterOuPas(); 
        
    }

}while(LoopRum == true);


bool ArreterOuPas()
{
    Console.WriteLine("Voulez-vous continuer à réserver ? (oui/non) : ");
    VoulezVousContinuer = Console.ReadLine();
    if(VoulezVousContinuer == "oui")
    {
        
        return true;
    }
        ResultatFinal(nombreTotalReserver, nombreTotalParticipant);
    
    return false;
}

void ContinueAreserver(string nomSalle,int capacite)
{
        Console.WriteLine("Voulez-vous réserver cette salle ? (oui/non) : ");
         Reserver = Console.ReadLine();
        if(Reserver == "oui"){
            nombreTotalReserver++;
            nombreTotalParticipant = 
            nombreTotalParticipant + Participant;
            Console.WriteLine($"{nomSalle} (capacité : ${capacite} personnes) réservée.");
           // ArreterOuPas();
            //return true;
        }


    //return false;
        
}


void ResultatFinal(int totalReservation, int totalParticipant){
    Console.WriteLine("Nombre total de réservations : " + totalReservation);
    Console.WriteLine("Nombre total de participants " + totalParticipant);

    //Console.WriteLine("La salle la plus réservée est : Salle 4 (capacité : 200 personnes) avec 1 réservations.");
}

string DeterminerLasalle(int participant, string salleName, int capacite)
{

 return "Salle Suggeres " + salleName + " (capacite : " + capacite + " Personne ) ";

}