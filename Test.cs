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
for (int i = 0; i <= winners.Count - 1; i++)
{
    if (!winners[i].ToLower().Contains('a'))
    {
        losers.Add(winners[i]);
        winners.RemoveAt(i);
        i--;
    }
}

for (int i = 0; i<= losers.Count - 1;  i++)
{
    if (losers[i].ToLower().Contains('a'))
    {
        winners.Add(losers[i]);
        losers.RemoveAt(i);
        i--;
    }
}


// Solution 2 LinQ


winners.AddRange(losers.Where(l=>l.ToLower().Contains('a'));
losers.AddRange(winners.Where(l=>!l.ToLower().Contains('a')):

winners = winners.RemoveAll(item => !winners.ToLower().Contains('a'));
losers = losers.RemoveAll(item => losers.ToLower().Contains('a'));
                
// Output 
Console.WriteLine("Winners after removal and addition: " + string.Join(", ", winners));
Console.WriteLine("Lossers after removal and addition: " + string.Join(", ", lossers));
                

