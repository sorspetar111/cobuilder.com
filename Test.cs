/*
Разпределете имената от двата списъка по следния начин:
 * в списък 'winners' оставете само имената съдържащи буква 'а'
 * в списъка 'losers' оставете само имената НЕ съдържащи буква 'а'
Без да създавате нови списъци или масиви.

*/
var winners = new List<string> {
            "Benji", "Hali", "Howie", "Christabella", "Anton", "Lexine", "Myrtle", "Derryl"};

var losers = new List<string> {
            "Indigo", "Kaitlyn", "Elicia", "Jackie", "Farrell", "Noah", "Rolf", "Lennon"};


// Solution 1 by item




// Solution 2 LinQ


winners.AddRange(losers.Where(l=>l.Contains('a'));
losers.AddRange(winners.Where(l=>!l.Contains('a')):

winners = winners.RemoveAll(item => !winners.Contains('a'));
losers = losers.RemoveAll(item => losers.Contains('a'));
                
// Output 
Console.WriteLine("Winners after removal and addition: " + string.Join(", ", winners));
Console.WriteLine("Lossers after removal and addition: " + string.Join(", ", lossers));
                
