 Random RandomCharacter = new Random();
        /// <summary>
        /// creates a random character "a-z"
        /// </summary>
        /// <returns>returns random letter</returns>
private char GetRandomCharacter()
        {
            return (char)RandomCharacter.Next(97, 123);
        }
