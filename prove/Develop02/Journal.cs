using System.Formats.Asn1;
using System.Formats.Tar;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
class Journal
{
    // string Random();
    // attributes
    public List<Entry> _prompts = new List<Entry>();
    public List<Entry>_entries = new List<Entry>();
    public string _fileName="";
    DateTime now = DateTime.Now;

    // behavior
    public void AddEntry()
    {
        Entry newResponse = new Entry();
        newResponse._date = now.ToString("dddd MM/dd/yyyy h:mm tt");
        Console.WriteLine($"{newResponse._date}");
        newResponse._prompt = PickPrompt();
        newResponse._response = Console.ReadLine();
        _entries.Add(newResponse);
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{AddEntry}");
    }
    public void LoadJournal()
    {
        Console.Write("What is the name of the file you want to grab from?: ");
        string LoAnswer = $"{Console.ReadLine()}.txt";
        string[] lines = File.ReadAllLines(LoAnswer);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void SaveEntry()
    {
        Console.Write("What would you like the name of the file to be?");
        string nameOfFile = Console.ReadLine();
        string Foi = $"{nameOfFile}.txt";
        string store ="";
        foreach(Entry print in _entries)
        {
            store += $"{print._date}\n";
            store += $"{print._prompt}\n";
            store += $"{print._response}\n";
        }
        if (File.Exists(Foi))
        {
            File.AppendAllText(Foi, store);
        }
        else
        {
            File.WriteAllText(Foi, store);
        }
    }
    public string PickPrompt()
    {
        string[] sentences = {
            "Who got you to become who you are now?",
            "What was today's definition like a dictionary?",
            "Where did the incident take place",
            "When will you get it done?",
            "Why did you come here?",
            "How was your day?",
            "Are things going as planned?",
            "What moment today stood out to you the most?",
            "What emotion was strongest for you today?",
            "What drained your energy today?",
            "What gave you energy today?",
            "What did you avoid today and why?",
            "What did you accomplish today that you’re proud of?",
            "What frustrated you today?",
            "What surprised you today?",            
            "What made you smile today?",            
            "What made you feel tense today?",
            "What did you learn about yourself today?",
            "What did you wish you had done differently?",
            "What conversation today mattered the most?",
            "What conversation today bothered you?",
            "What did you spend too much time thinking about?",
            "What did you not think about enough?",
            "What did you do today that aligned with your goals?",
            "What habit showed up today?",
            "What habit disappeared today?",
            "What did you procrastinate on?",
            "What did you complete faster than expected?",
            "What did you feel grateful for today?",
            "What did you feel annoyed by today?",
            "What did you avoid feeling today?",
            "What emotion surprised you today?",
            "What did you say today that you wish you hadn’t?",
            "What did you not say today that you wish you had?",
            "What did you notice about your environment?",
            "What did you notice about your body?",
            "What did you notice about your thoughts?",
            "What did you notice about your reactions?",
            "What did you do today that felt meaningful?",
            "What felt meaningless today?",
            "What did you want today?",
            "What did you need today?",
            "What did you ignore today?",
            "What did you pay attention to today?",
            "What did you fear today?",
            "What did you overcome today?",
            "What did you hope for today?",
            "What disappointed you today?",
            "What motivated you today?",
            "What discouraged you today?",
            "What did you enjoy doing today?",
            "What did you force yourself to do today?",
            "What did you avoid doing today?",
            "What did you wish you had more time for?",
            "What did you wish you had less time for?",
            "What did you feel confident about today?",
            "What did you feel insecure about today?",
            "What did you do today that helped someone?",
            "What did someone do today that helped you?",
            "What did you misunderstand today?",
            "What did someone misunderstand about you?",
            "What did you forgive today?",
            "What did you struggle to forgive today?",
            "What did you accept today?",
            "What did you resist today?",
            "What did you let go of today?",
            "What did you hold onto today?",
            "What did you say yes to today?",
            "What did you say no to today?",
            "What boundary did you keep today?",
            "What boundary did you break today?",
            "What boundary did someone cross today?",
            "What boundary did someone respect today?",
            "What did you feel proud of today?",
            "What did you feel ashamed of today?",
            "What did you feel confused about today?",
            "What did you feel certain about today?",
            "What did you feel curious about today?",
            "What did you feel bored with today?",
            "What did you feel excited about today?",
            "What did you feel nervous about today?",
            "What did you feel peaceful about today?",
            "What did you avoid thinking about today?",
            "What did you think about repeatedly?",
            "What did you imagine today?",
            "What did you remember today?",
            "What did you forget today?",
            "What did you discover today?",
            "What did you question today?",
            "What did you doubt today?",
            "What did you trust today?",
            "What did you rely on today?",
            "What did you change today?",
            "What stayed the same today?",
            "What did you wish you could change?",
            "What did you wish would stay the same?",
            "What did you notice about your routine?",
            "What disrupted your routine?",
            "What improved your routine?",
            "What made today feel different?",
            "What made today feel ordinary?",
            "What made today feel difficult?",
            "What made today feel easy?",
            "What made today feel meaningful?",
            "What made today feel chaotic?",
            "What made today feel calm?",
            "What did you want to say but didn’t?",
            "What did you say without thinking?",
            "What did you think before speaking?",
            "What did you think after speaking?",
            "What did you regret today?",
            "What did you appreciate today?",
            "What did you ignore today?",
            "What did you confront today?",
            "What did you avoid confronting?",
            "What did you express today?",
            "What did you suppress today?",
            "What did you hope someone would notice?",
            "What did you hope no one would notice?",
            "What did you feel connected to today?",
            "What did you feel disconnected from?",
            "What did you feel responsible for today?",
            "What did you feel overwhelmed by?",
            "What did you feel relieved about?",
            "What did you feel pressured by?",
            "What did you feel supported by?",
            "What did you feel alone in?",
            "What did you feel proud of accomplishing?",
            "What did you feel behind on?",
            "What did you feel ahead on?",
            "What did you feel stuck on?",
            "What did you feel free from?",
            "What did you feel inspired by?",
            "What did you feel discouraged by?",
            "What did you feel hopeful about?",
            "What did you feel uncertain about?",
            "What did you feel determined about?",
            "What did you feel hesitant about?",
            "What did you feel grateful for?",
            "What did you feel annoyed by?",
            "What did you feel surprised by?",
            "What did you feel disappointed by?",
            "What did you feel proud of handling?",
            "What did you feel unprepared for?",
            "What did you feel ready for?",
            "What did you feel tired of?",
            "What did you feel excited to start?",
            "What did you feel reluctant to start?",
            "What did you feel satisfied with?",
            "What did you feel unsatisfied with?",
            "What did you feel confident doing?",
            "What did you feel unsure doing?",
            "What did you feel motivated to do?",
            "What did you feel too tired to do?",
            "What did you feel curious to explore?",
            "What did you feel uninterested in?",
            "What did you feel grateful someone said?",
            "What did you wish someone had said?",
            "What did you wish someone hadn’t said?",
            "What did you wish you had asked?",
            "What did you wish you hadn’t asked?",
            "What did you notice about your mood?",
            "What did you notice about your patience?",
            "What did you notice about your focus?",
            "What did you notice about your distractions?",
            "What did you notice about your habits?",
            "What did you notice about your reactions?",
            "What did you notice about your thoughts?",
            "What did you notice about your feelings?",
            "What did you notice about your choices?",
            "What did you notice about your priorities?",
            "What did you notice about your values?",
            "What did you notice about your goals?",
            "What did you notice about your progress?",
            "What did you notice about your setbacks?",
            "What did you notice about your strengths?",
            "What did you notice about your weaknesses?",
            "What did you notice about your relationships?",
            "What did you notice about your communication?",
            "What did you notice about your boundaries?",
            "What did you notice about your expectations?",
            "What did you notice about your assumptions?",
            "What did you notice about your hopes?",
            "What did you notice about your fears?",
            "What did you notice about your dreams?",
            "What did you notice about your worries?",
            "What did you notice about your intentions?",
            "What did you notice about your actions?",
            "What did you notice about your choices?",
            "What did you notice about your environment?",
            "What did you notice about your comfort?",
            "What did you notice about your discomfort?",
            "What did you notice about your motivation?",
            "What did you notice about your discipline?",
            "What did you notice about your distractions?",
            "What did you notice about your priorities?",
            "What did you notice about your time?",
            "What did you notice about your energy?",
            "What did you notice about your mindset?",
            "What did you notice about your resilience?",
            "What did you notice about your patience?",
            "What did you notice about your confidence?",
            "What did you notice about your self‑talk?",
            "What did you notice about your decisions?",
            "What did you notice about your day overall?",
            "What do you want tomorrow to feel like?",
        };
        int randomIndex = Random.Shared.Next(sentences.Length);
        string pt = sentences[randomIndex];
        Console.WriteLine($"{pt}");
        return pt;
        
    }



    //  List<Entry> myEntries = new List<Entry>();

    // Entry e = new Entry();
    // DateTime now = DateTime.Now;

    // e._date = now.ToString("dddd MM/dd/yyyy h:mm tt");
    // e._prompt = "Your prompt here";
    // e._response = Console.ReadLine();

    
    
}