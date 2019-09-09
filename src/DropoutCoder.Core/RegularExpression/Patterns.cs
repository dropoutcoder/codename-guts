using System;
using System.Collections.Generic;
using System.Text;
using DropoutCoder.Core.Input.Cloudikka.Core.Input;

namespace DropoutCoder.Core.RegularExpression {
    public static partial class Patterns {
        #region String Anchors

        public static readonly string StringStartAnchor = Keyboard.Symbols.Caret;
        public static readonly string StringEndAnchor = Keyboard.Symbols.Dollar;

        #endregion

        #region Character Class

        public static readonly string CharacterClassStart = Keyboard.Symbols.SquareBracketOpening;
        public static readonly string CharacterClassEnd = Keyboard.Symbols.SquareBracketClosing;

        #endregion

        #region Shorthands

        public static readonly string Word = Keyboard.Symbols.Backslash + Keyboard.Letters.Lowercase.w; // @"\w"
        public static readonly string NotWord = Keyboard.Symbols.Backslash + Keyboard.Letters.Uppercase.W; // @"\W"
        public static readonly string WhiteSpace = Keyboard.Symbols.Backslash + Keyboard.Letters.Lowercase.s; // @"\s"
        public static readonly string NotWhiteSpace = Keyboard.Symbols.Backslash + Keyboard.Letters.Uppercase.S; // @"\S"
        public static readonly string Digit = Keyboard.Symbols.Backslash + Keyboard.Letters.Lowercase.d; // @"\d"
        public static readonly string NotDigit = Keyboard.Symbols.Backslash + Keyboard.Letters.Uppercase.S; // @"\D"

        #endregion


        public static readonly string ZeroOrMore = Keyboard.Symbols.Asterisk;
        public static readonly string OneOrMore = Keyboard.Symbols.Plus;
        public static readonly string ZeroOrOne = Keyboard.Symbols.QuestionMark;
        public static readonly string LazySearch = Keyboard.Symbols.QuestionMark;
        public static readonly string RangeDelimiter = Keyboard.Symbols.Minus;
        public static readonly string Alternation = Keyboard.Symbols.Pipe;


        public static readonly string OneOrMoreWhiteSpace = WhiteSpace + OneOrMore;
        public static readonly string AnyLetter = @"(\p{L})+";
        public static readonly string NonDiacritics = StringStartAnchor + "[a-zA-Z]" + OneOrMore + StringEndAnchor;
        public static readonly string Email = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|'(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\\[\x01-\x09\x0b\x0c\x0e-\x7f])*')@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])\z";

    }
}
