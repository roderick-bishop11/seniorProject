using OBGAPI.DataModels;
using OBGAPI.Repos;
using System.Random;


//this service will make the queries and single selections out of the lists returned from the DByo
namespace OBGAPI.Service {

public class SelectSingle{

private readonly Random  _num = new Random();

//SONG
public static Song singleSong(List<Song> songs){

    return songs[_num.Next(0,(songs.Count-1))];
}

//FIGURE
public static Figure singleFigure(List<Figure> figures){
    
    return figures[_num.Next(0,(figures.Count-1))];
}

//Invention
public static Invention singleInv(List<Invention> inventions){

    return inventions[_num.Next(0,(inventions.Count-1))];
}

//facts 

public static Fact singleFact(List<Fact> facts){
        return facts[_num.Next(0,(facts.Count-1))];

}

}