namespace Cats_FTW.Migrations
{
    using Cats_FTW.Classes;
    using Cats_FTW.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cats_FTW.Migrations.SQLDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cats_FTW.Migrations.SQLDbContext context)
        {
            AddOrUpdateCatFacts(context);
        }

        private static void AddOrUpdateCatFacts(SQLDbContext context)
        {
            //Source: https://catfact.ninja/#/Facts/getFacts

            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "A", Text = "Cats can jump up to 7 times their tail length." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "B", Text = "Cat's urine glows under a black light." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "C", Text = "The technical term for a cat’s hairball is a “bezoar.”" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "D", Text = "A group of cats is called a “clowder.”" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "1", Text = "Cats make about 100 different sounds. Dogs make only about 10." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "2", Text = "Every year, nearly four million cats are eaten in Asia." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "3", Text = "Approximately 24 cat skins can make a coat." });
            context.SaveChanges();
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "4", Text = "Approximately 40,000 people are bitten by cats in the U.S. annually." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "5", Text = "Cats have 300 million neurons; dogs have about 160 million" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "6", Text = "A cat can jump up to five times its own height in a single bound." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "7", Text = "A cat usually has about 12 whiskers on each side of its face." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "8", Text = "A cat’s jaw can’t move sideways, so a cat can’t chew large chunks of food." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "9", Text = "Like humans, cats tend to favor one paw over another" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "10", Text = "All cats have claws, and all except the cheetah sheath them when at rest." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "11", Text = "A cat lover is called an Ailurophilia (Greek: cat+lover)." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "12", Text = "Approximately 1/3 of cat owners think their pets are able to read their minds." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "13", Text = "In the 1750s, Europeans introduced cats into the Americas to control pests." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "14", Text = "Cats control the outer ear using 32 muscles; humans use 6" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "15", Text = "If they have ample water, cats can tolerate temperatures up to 133 °F." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "16", Text = "Cats spend nearly 1/3 of their waking hours cleaning themselves." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "17", Text = "A female cat is called a queen or a molly." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "18", Text = "There are up to 60 million feral cats in the United States alone." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "19", Text = "Cats have supersonic hearing" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "20", Text = "The richest cat is Blackie who was left £15 million by his owner, Ben Rea." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "21", Text = "A cat can sprint at about thirty-one miles per hour." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "22", Text = "An adult lion's roar can be heard up to five miles (eight kilometers) away." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "23", Text = "A cat will tremble or shiver when it is extreme pain." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "24", Text = "A cat's normal pulse is 140-240 beats per minute, with an average of 195." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "25", Text = "Tigers are excellent swimmers and do not avoid water." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "26", Text = "The leopard is the most widespread of all big cats." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "27", Text = "While many cats enjoy milk, it will give some cats diarrhea." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "28", Text = "Female cats are polyestrous" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "29", Text = "A cat will tremble or shiver when it is in extreme pain." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "30", Text = "Cats step with both left legs, then both right legs when they walk or run." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "31", Text = "A domestic cat can run at speeds of 30 mph." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "32", Text = "Cats lap liquid from the underside of their tongue, not from the top." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "33", Text = "Cats take between 20-40 breaths per minute." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "34", Text = "The Maine Coone is the only native American long haired breed." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "35", Text = "Cats have been domesticated for half as long as dogs have been." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "36", Text = "The first formal cat show was held in England in 1871; in America, in 1895." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "37", Text = "The average litter of kittens is between 2 - 6 kittens." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "38", Text = "In one stride, a cheetah can cover 23 to 26 feet (7 to 8 meters)." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "39", Text = "The cat's tail is used to maintain balance." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "40", Text = "A cat's brain is more similar to a man's brain than that of a dog." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "41", Text = "A cat's normal temperature varies around 101 degrees Fahrenheit." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "42", Text = "A form of AIDS exists in cats." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "43", Text = "In 1987 cats overtook dogs as the number one pet in America." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "44", Text = "A cat can jump 5 times as high as it is tall." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "45", Text = "A steady diet of dog food may cause blindness in your cat - it lacks taurine." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "46", Text = "When a domestic cat goes after mice, about 1 pounce in 3 results in a catch." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "47", Text = "Many cats love having their forehead gently stroked." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "48", Text = "A cat has two vocal chords, and can make over 100 sounds." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "49", Text = "Cats bury their feces to cover their trails from predators." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "50", Text = "The Ancient Egyptian word for cat was mau, which means \"to see\"." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "51", Text = "There are approximately 100 breeds of cat." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "53", Text = "Cats lived with soldiers in trenches, where they killed mice during World War I." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "54", Text = "About 37% of American homes today have at least 1 cat." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "55", Text = "Kittens remain with their mother till the age of 9 weeks." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "56", Text = "A tomcat (male cat) can begin mating when he is between 7 and 10 months old." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "57", Text = "Today there are about 100 distinct breeds of the domestic cat." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "58", Text = "Julius Ceasar, Henri II, Charles XI, and Napoleon were all afraid of cats." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "59", Text = "Cats have the largest eyes of any mammal." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "60", Text = "Most cats adore sardines." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "61", Text = "A cat's normal pulse is 140-240 beats per minute, with an average of 195." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "62", Text = "A cat can spend five or more hours a day grooming himself." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "63", Text = "British cat owners spend roughly 550 million pounds yearly on cat food." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "64", Text = "It is estimated that cats can make over 60 different sounds." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "65", Text = "Heat occurs several times a year and can last anywhere from 3 to 15 days." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "66", Text = "Cats' hearing is much more sensitive than humans and dogs." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "67", Text = "Cats must have fat in their diet because they can't produce it on their own." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "68", Text = "Blue-eyed, pure white cats are frequently deaf." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "69", Text = "The Amur leopard is one of the most endangered animals in the world." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "70", Text = "On average, a cat will sleep for 16 hours a day." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "71", Text = "A tiger's stripes are like fingerprints" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "72", Text = "The life expectancy of cats has nearly doubled over the last fifty years." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "73", Text = "A cat's field of vision is about 200 degrees." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "74", Text = "A healthy cat has a temperature between 38 and 39 degrees Celcius." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "75", Text = "Unlike other cats, lions have a tuft of hair at the end of their tails." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "75", Text = "Jaguars are the only big cats that don't roar." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "76", Text = "Cats can be right-pawed or left-pawed." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "77", Text = "Cats walk on their toes." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "78", Text = "The first official cat show in the UK was organised at Crystal Palace in 1871." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "79", Text = "The first cat show was in 1871 at the Crystal Palace in London." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "80", Text = "A happy cat holds her tail high and steady." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "81", Text = "Cats see six times better in the dark and at night than humans." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "82", Text = "Blue-eyed, white cats are often prone to deafness." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "83", Text = "In relation to their body size, cats have the largest eyes of any mammal." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "84", Text = "An adult lion's roar can be heard up to five miles (eight kilometers) away." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "85", Text = "Owning a cat is actually proven to be beneficial for your health." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "86", Text = "In 1987 cats overtook dogs as the number one pet in America." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "87", Text = "A cat has more bones than a human; humans have 206, and the cat - 230." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "88", Text = "Cats dislike citrus scent." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "89", Text = "Cats respond most readily to names that end in an \\ee\\\" sound.\"\"\"" });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "90", Text = "Neutering a cat extends its life span by two or three years." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "91", Text = "The Pilgrims were the first to introduce cats to North America." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "92", Text = "A cat's hearing is much more sensitive than humans and dogs." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "93", Text = "A cat will tremble or shiver when it is extreme pain." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "94", Text = "A cats field of vision is about 185 degrees." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "95", Text = "Cheetahs do not roar, as the other big cats do. Instead, they purr." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "96", Text = "Ailurophile is the word cat lovers are officially called." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "97", Text = "The cat has 500 skeletal muscles (humans have 650)." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "98", Text = "Florence Nightingale owned more than 60 cats in her lifetime." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "99", Text = "Cat bites are more likely to become infected than dog bites." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "100", Text = "Tylenol and chocolate are both poisionous to cats." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "101", Text = "Fossil records from two million years ago show evidence of jaguars." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "102", Text = "In multi-cat households, cats of the opposite sex usually get along better." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "103", Text = "Normal body temperature for a cat is 102 degrees F." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "104", Text = "A cat cannot see directly under its nose." });
            context.SaveChanges();
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "105", Text = "Baking chocolate is the most dangerous chocolate to your cat." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "106", Text = "Cats' hearing stops at 65 khz (kilohertz); humans' hearing stops at 20 khz." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "107", Text = "The average cat food meal is the equivalent to about five mice." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "108", Text = "The cat's footpads absorb the shocks of the landing when the cat jumps." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "109", Text = "Cats can jump up to 7 times their tail length." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "110", Text = "A queen (female cat) can begin mating when she is between 5 and 9 months old." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "111", Text = "Milk can give some cats diarrhea." });
            //context.CatFacts.AddOrUpdate(new CatFact { UID = "112", Text = "The life expectancy of cats has nearly doubled since 1930 - from 8 to 16 years." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "113", Text = "Ginger tabby cats can have freckles around their mouths and on their eyelids!" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "114", Text = "The Cat Fanciers Association (CFA) recognizes 44 breeds of cats." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "115", Text = "Cats only sweat through their paws and nowhere else on their body" });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "118", Text = "A cat's nose is as unique as a human's fingerprint." });
            context.CatFacts.AddOrUpdate(new Models.CatFact { UID = "119", Text = "Cats have 3 eyelids." });

            context.SaveChanges();
        }
    }
}
