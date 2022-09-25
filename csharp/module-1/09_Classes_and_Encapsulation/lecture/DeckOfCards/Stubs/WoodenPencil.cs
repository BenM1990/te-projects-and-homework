using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DeckOfCards.Stubs
{
    /// <summary>
    /// NAMESPACE DEFINTION
    /// 
    /// Uppercase and alligned with a module or general purpose it provides
    /// Separated by periods like TechElevator.Classes
    /// </summary>
    /// 




    ////<summary>
    ///CLASS DECLARATIOn
    ///Naming convention: singular and PascalCase
    ///</summary>
    public class WoodenPencil
    {
        ///<summary>
        ///Class Variables and Properties
        /// static modifier, or const (implicit static).
        /// May be public or private
        /// Often const, but not required to be
        /// </summary>

        ///public - other classes and methods have access.
        public const double DefaultLength = 8.0;
        public const int DefaultShape = 2;
        public const string DefaultHardness = "HB";
        public static readonly Color DefaultColor = Color.Yellow;
        public const double DefaultStubLength = 2.0;
        public const double DefaultMaxDullness = 0.3;

        private static double stubLength = DefaultStubLength; //when a pencil is considered a stub, in inches

        public double Length { get; set; }

    }
}
