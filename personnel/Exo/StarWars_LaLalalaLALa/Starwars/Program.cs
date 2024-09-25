using Newtonsoft.Json;
using System.Linq;

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
dynamic result = JsonConvert.DeserializeObject<dynamic>(responseBody);
int longuest = 0;

/*dynamic longuestMovie = result.results[0];
foreach (dynamic item in result.results)
{
    if (((string)item.title).Length > longuest)
    {
        longuest = ((string)item.title).Length;
        longuestMovie = item;
    }
}*/
/*Console.WriteLine($"Le plus long film : {longuestMovie.title}\nNombre de caractère : {((string)longuestMovie.title).Length}");*/


//Exo n°1

// /films

//var movies = new List<dynamic> { };
//foreach (var item in result.results)
//{
//    movies.Add(item);
//}
/*var longuestMovie = movies
    .OrderByDescending(item => (((string)item.title).Length))
    .First();
Console.WriteLine($"Le plus long film : {longuestMovie.title}\nNombre de caractères : {((string)longuestMovie.title).Length}");
*/

//Exo n°2

// /people


var peoples = new List<dynamic> { };
foreach (var item in result.results)
{
    peoples.Add(item);
}

var mostAppear = peoples
    .OrderByDescending(item => (Array)item.films.Length)
    .First();
Console.WriteLine($"Le personnage qui est dans le plus de film est : {mostAppear.name}");
//Console.WriteLine($"Le personnage qui est dans le plus de film est : {mostAppear.name}\nNombre d'apparition : {(List<dynamic>)mostAppear.films.Length)}");

Console.ReadLine();