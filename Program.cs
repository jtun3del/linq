﻿using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
//var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
//foreach(var characterByYearCreated in CharactersByYearCreated)
//{
//  Console.WriteLine(characterByYearCreated.Key);
//  foreach(var character in characterByYearCreated) {
  //  Console.WriteLine($"\t{character.Name}");
  //}
//}

// var oldchars = from Character ninty in characters
// where ninty.YearCreated == 1981
// select ninty;

// foreach(Character ninty in oldchars)
//   Console.Write(ninty.Display() + " ");



// var oldchars = from Character ninty in characters
// where ninty.YearCreated == 1981
// select ninty;

// foreach(Character ninty in oldchars){
//   Console.Write(ninty.Name + " series: ");
//   var serieses = ninty.Series;
//   foreach(String serie in serieses) {
//     Console.Write(serie + ", ");
//   }
//   Console.WriteLine("");
// }

// var olddks = from Character ninty in dks
// where ninty.YearCreated == 1981
// select ninty;

// foreach(Character ninty in olddks)
//   Console.Write(ninty.Name  + " ");


// var from64 = from Character ninty in dks
// where ninty.FirstAppearance == "Donkey Kong 64"
// select ninty;

// foreach(Character ninty in from64)
//   Console.Write(ninty.Name  + " ");



// var noalias = from Character ninty in characters
// where ninty.Alias.Count == 0
// select ninty;

// int x = 0;
//  foreach(Character ninty in noalias){
//   x += 1;
//  }

// Console.Write(x);


// var noalias = from Character ninty in characters
// where ninty.Alias.Count == 0
// select ninty;

// foreach(Character ninty in noalias){
//   Console.WriteLine(ninty.Name  + " ");
//   Console.Write("alias: ");
//   foreach(var i in ninty.Alias){ Console.Write(i + ", ");}
//   Console.Write("series: ");
//   foreach(var i in ninty.Series){ Console.Write(i + ", ");}
// }


// Console.WriteLine($"How many? {marios.Count}");


// foreach(var obj in characters.Where(c => c.Alias.Count == 0)){
//   Console.WriteLine($"{obj.Name}, alias(s):\n\t{String.Join(", ", obj.Alias)} ");
// }

// Console.WriteLine($"it is {dks.Any(c => c.Alias.Count == 0)}");

// Console.WriteLine($"there are {dks.Count(c => c.Alias.Count == 0)}");

foreach(var obj in dks.Where(c => c.Alias.Count == 0)){
  Console.WriteLine($"{obj.Name}, alias(s):\n\t{String.Join(", ", obj.Alias)} ");
}
