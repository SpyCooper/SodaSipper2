using TMPro;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    public string[] quotes = new string[]
    {
        "I have become Soda, sipper of worlds.",
        "She sip on my soda til I defeat the evil wizard.",
        "I love soda.",
        "Soda is really good.",
        "She sips on my soda til I go flat.",
        "National sip shortage negated by one deranged individual",
        "Soda: the ultimate blend of fizz, flavor, and fun.",
        "Man I love only cans.",
        "Soda: a refreshing escape in a can.",
        "Pop open a soda and let the bubbles tickle your taste buds.",
        "Sip, savor, soda.",
        "In a world full of choices, choose soda.",
        "Soda: the perfect companion for any occasion.",
        "You can't buy happiness, but you can buy soda, and that's pretty much the same thing.",
        "Soda: a little sip of happiness.",
        "Fizz, flavor, and fantastic refreshment - that's what soda is all about.",
        "Life's too short for bland beverages. Choose soda, choose excitement.",
        "Let your worries fizz away with a cold soda in hand.",
        "Soda: the carbonated cure for thirst.",
        "Pop the top and let the magic out - soda time!",
        "Why drink water when you can have soda?",
        "Soda: the ultimate refresher, every sip is a celebration.",
        "Indulge in the effervescence of soda and let your taste buds dance.",
        "There's something about soda that just puts a smile on your face.",
        "Soda: the elixir of choice for the modern age.",
        "Life's too short to drink boring beverages. Reach for soda and add some sparkle to your day.",
        "Life as we know it will soon come to an end; drink the soda.",
        "Soda",
        "Your time will come...",
        "Sipping soda is a safe and legal thrill",
        "Maidens love architecture, bitches love tanks",
        "Things are about to get carbonated.",
        "When you're dodging lickers and dodging explosions, sometimes all you need is a refreshing soda to keep your cool.",
        "Soda is the mindfizzer, soda is the little sip that leads to total carbonation,\nI will face my soda, I will let it pass over and through me..."
    };

    [SerializeField] private TMP_Text TickerBox;
    private void Awake() => Random.InitState(System.DateTime.Now.Second + System.DateTime.Now.Millisecond);
    private void Start() => ChangeText();
    public void ChangeText() => TickerBox.text = quotes[Random.Range(0, quotes.Length)];
}