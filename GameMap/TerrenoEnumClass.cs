using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum TerrenoEnum{
    Terra,
    Fogo,
    Água,
    Grama

}

public static class TerrenoEnumExtension{
    public static ConsoleColor GetColor(this TerrenoEnum terreno){
        switch(terreno){
            case TerrenoEnum.Terra:
                return ConsoleColor.DarkYellow;
            case TerrenoEnum.Fogo:
                return ConsoleColor.Red;
            case TerrenoEnum.Água:
                return ConsoleColor.Blue;
            case TerrenoEnum.Grama:
                return ConsoleColor.Green;
            default:
                return ConsoleColor.White;
        }
    }

    public static char GetChar(this TerrenoEnum terreno){
        switch(terreno){
            case TerrenoEnum.Terra: return '\u25cb';
            case TerrenoEnum.Fogo: return '\u2248';
            case TerrenoEnum.Água: return '\u2248';
            case TerrenoEnum.Grama: return '\u201c';
            default: return ' ';
        }
    }
}