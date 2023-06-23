using System.Runtime.CompilerServices;

namespace Greeter;

public class GreetingMaker
{

    private readonly IProvideBannedNames _bannedNamesService;
    private readonly INotifyOfTrolls _trollNotifier;

    public GreetingMaker(IProvideBannedNames bannedNamesService, INotifyOfTrolls trollNotifier)
    {
        _bannedNamesService = bannedNamesService;
        _trollNotifier = trollNotifier;
    }

    public string Greet(params string[] names)
    {
        var bannedNames = _bannedNamesService.GetListOfBannedNames();
        var namesThatAreInTheBannedList = names.Intersect(bannedNames).ToList();
        CheckAndNotifyOfTrolls(names, namesThatAreInTheBannedList);
        names = SanitizeNamesFromBannedList(names, namesThatAreInTheBannedList);
       
        return GetResults(names);
    }

    private static string GetResults(string[] names)
    {
        bool allUpper = IsEveryoneShouting(names);

        var someUpper = !allUpper && AreSomePeopleShouting(names);
        return someUpper ? DealWithTheShouters(names) : NoShouters(names, allUpper);
    }

    private static string NoShouters(string[] names, bool allUpper)
    {
        var prefix = allUpper ? "HELLO" : "Hello";
        var separator = allUpper ? "AND" : "and";
        if (names.Length > 1)
        {
            var beginning = names.Take(names.Length - 1).ToArray();
            var last = names[names.Length - 1];
            var startNames = string.Join(", ", beginning);

            return $"{prefix}, {startNames}, {separator} {last}!";
        }
        else
        {
            return $"{prefix}, {names[0]}!";
        }
    }

    private static string DealWithTheShouters(string[] names)
    {
        var nonShoutedNames = names.Where(n => n.ToUpperInvariant() != n).ToList();
        var shoutedNames = names.Except(nonShoutedNames);
        var response = $"Hello, {string.Join(", ", nonShoutedNames)}, AND {string.Join(", ", shoutedNames)}!";
        return response;
    }

    private static bool AreSomePeopleShouting(string[] names)
    {
        return names.Any(n => n.ToUpperInvariant() == n);
    }

    private static bool IsEveryoneShouting(string[] names)
    {
        return names.All(n => n.ToUpperInvariant() == n);
    }

    private static string[] SanitizeNamesFromBannedList(string[] names, List<string> attemptedBannedNames)
    {
        if (attemptedBannedNames.Any())
        {
            var ellidedNames = new List<string>();
            var cleanNames = new List<string>();
            foreach (var name in names)
            {
                if (attemptedBannedNames.Contains(name)) { 
                    ellidedNames.Add(StringUtilties.Elide(name)); 
                } else 
                { 
                    cleanNames.Add(name); 
                }
            }
            names = cleanNames.Concat(ellidedNames).ToArray();
        }

        return names;
    }

    private void CheckAndNotifyOfTrolls(string[] names, List<string> attemptedBannedNames)
    {
        if (attemptedBannedNames.Count == names.Length)
        {
            _trollNotifier.Notify("User Used All Invalid Names: " + string.Join(", ", attemptedBannedNames));
        }
    }

}