using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int totalRacoons = 3;
            int racoonsThatWentHome = 2;
            int racoonsLeft = totalRacoons - racoonsThatWentHome;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int totalFlowers = 5;
            int totalBees = 3;
            int totalLessBeesThanFlowers = totalFlowers - totalBees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int numberOfPigeonsInGroupOne = 1;
            int numberOfPigeonsInGroupTwo = 1;
            int totalPigeons = numberOfPigeonsInGroupOne + numberOfPigeonsInGroupTwo;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numberOfOwlsOnFence = 3;
            int owlsThatJoined = 2;
            int totalOwls = numberOfOwlsOnFence + owlsThatJoined;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int totalBeaversWorking = 2;
            int beaversThatWentForASwim = 1;
            int totalBeaversWorkingFinal = totalBeaversWorking - beaversThatWentForASwim;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int toucansSittingOnTreeLimbOriginal = 2;
            int toucansThatJoined = 1;
            int totalToucans = toucansSittingOnTreeLimbOriginal + toucansThatJoined;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int totalSquirrels = 4;
            int totalNuts = 2;
            int totalNumberOfMoreSquirrelsThanNuts = totalSquirrels - totalNuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal totalInDimes = 0.10M;
            decimal totalInNickels = 0.10M;
            decimal totalInQuarters = 0.25M;
            decimal totalMoney = totalInDimes + totalInNickels + totalInQuarters;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int muffinsInMrsBriersClass = 18;
            int muffinsInMrsMacAdamsClass = 20;
            int muffinsInMrsFlannerysClass = 17;
            int totalMuffinsInFirstGrade = muffinsInMrsBriersClass + muffinsInMrsMacAdamsClass + muffinsInMrsFlannerysClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal costOfYoyo = 0.24M;
            decimal costOfWhistle = 0.14M;
            decimal totalCostOfToys = costOfYoyo + costOfWhistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int totalLargeMarshmallows = 8;
            int totalMiniMarshmallows = 10;
            int totalMarshmallows = totalLargeMarshmallows + totalMiniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowMrsHilt = 29;
            int inchesOfSnowBrecknockElementary = 17;
            int differenceInSnow = inchesOfSnowMrsHilt - inchesOfSnowBrecknockElementary;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double beginningTotalOfMoney = 10.00;
            double amountSpentOnTruck = 3.00;
            double amountSpentOnPencilCase = 2.00;
            double finalAmountOfMoney = beginningTotalOfMoney - amountSpentOnTruck - amountSpentOnPencilCase;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int collectionOfMarbles = 16;
            int marblesLost = 7;
            int totalMarbles = collectionOfMarbles - marblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int currentNumberOfSeashells = 19;
            int numberOfSeashellsNeeded = 25;
            int differenceInSeashells = numberOfSeashellsNeeded - currentNumberOfSeashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBaloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentTotalBooksOnShelf = 38;
            int booksAddedToShelf = 10;
            int totalBooks = currentTotalBooksOnShelf + booksAddedToShelf;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int totalNumberOfBees = 8;
            int totalBeeLegs = beeLegs * totalNumberOfBees;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal costOfIceCreamCone = 0.99M;
            int numberOfIceCreamCones = 2;
            decimal totalCostOfIceCreamCones = costOfIceCreamCone * numberOfIceCreamCones;


            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currentNumberOfRocks = 64;
            int numberOfRocksNeeded = 125;
            int differenceInRocksNeeded = numberOfRocksNeeded - currentNumberOfRocks;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltOriginaltMarbleTotal = 38;
            int hiltMarblesLost = 15;
            int hiltCurrentMarbleTotal = hiltOriginaltMarbleTotal - hiltMarblesLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertDistanceMiles = 78;
            int totalDrivenMiles = 32;
            int milesLeftToDrive = concertDistanceMiles - totalDrivenMiles;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int minutesShovelingMorning = 90;
            int minutesShovelingAfternoon = 45;
            int totalMinutesShoveling = minutesShovelingMorning + minutesShovelingAfternoon;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totalHotDogs = 6;
            decimal costOfSingleHotDog = 0.50M;
            decimal totalForHotDogs = totalHotDogs * costOfSingleHotDog;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal mrsHiltTotalMoney = 0.50M;
            decimal costOfSinglePencil = 0.07M;
            int totalPencilsBought = (int)(double)(mrsHiltTotalMoney / costOfSinglePencil);

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int totalOrangeButterflies = 20;
            int totalRedButerflies = totalButterflies - totalOrangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal amountPaidForCandy = 1.00M;
            decimal totalCostOfCandy = 0.54M;
            decimal totalChangeReturned = amountPaidForCandy - totalCostOfCandy;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInBackyard = 13;
            int newTreesPlaneted = 12;
            int totalTreesCurrent = treesInBackyard + newTreesPlaneted;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursInADay = 24;
            int totalDaysToWaitForGrandma = 2;
            int hoursUntilJoySeesGrandma = totalDaysToWaitForGrandma * hoursInADay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int totalCousins = 4;
            int gumPerCousin = 5;
            int totalGumNeeded = totalCousins * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danCurrentMoneyAmount = 3.00M;
            decimal danMoneySpent = 1.00M;
            decimal danNewCurrentMoneyAmount = danCurrentMoneyAmount - danMoneySpent;

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInLake = 5;
            int peoplePerBoat = 3;
            int totalPeopleInBoatsOnLake = boatsInLake * peoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellenStartingLegoAmount = 380;
            int ellenLegosLost = 57;
            int ellenCurrentLegoAmount = ellenStartingLegoAmount - ellenLegosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurMuffinsBaked = 35;
            int arthurMuffinsNeeded = 83;
            int arthurMuffinsLeftToBake = arthurMuffinsNeeded - arthurMuffinsBaked;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayonTotal = 1400;
            int lucyCrayonTotal = 290;
            int differenceInCrayons = willyCrayonTotal - lucyCrayonTotal;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnAPage = 10;
            int numberOfPagesOfStickers = 22;
            int totalNumberOfStickers = stickersOnAPage * numberOfPagesOfStickers;

            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double totalCupcakes = 100.00;
            double numberOfChildren = 8.00;
            double totalCupcakesPerChild = totalCupcakes / (numberOfChildren);
            
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int totalCookies = 47;
            int cookiesPerJar = 6;
            int leftoverCookies = 47 % 6;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int croissantsGiven = 8;
            int totalCroissantsForMarian = 59 % 8;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int cookiesNeeded = 276;
            int totalTraysNeeded = 276 / 12;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int pretzelsPerServing = 12;
            int totalServingsOfPretzels = totalPretzels / pretzelsPerServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalLemonCupcakesBaked = 53;
            int cupcakesLeftAtHome = 2;
            int cupcakesInABox = 3;
            int totalCupcakeBoxesGivenAway = (totalLemonCupcakesBaked - cupcakesLeftAtHome) / cupcakesInABox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotsPrepared = 74;
            int numberOfPeople = 12;
            int carrotsLeftAfterServedEqually = carrotsPrepared % numberOfPeople;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberOfTeddyBears = 98;
            int teddyBearsPerShelf = 7;
            int totalShelvesFilled = numberOfTeddyBears / teddyBearsPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalNumberOfPictures = 480;
            int picturesPerAlbum = 20;
            int totalAlbumsNeeded = totalNumberOfPictures / picturesPerAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int cardsInABox = 8;
            int boxesFilled = (int)((double)totalTradingCards / cardsInABox);
            int cardsInUnfilledBox = totalTradingCards - (boxesFilled * cardsInABox);

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalFatherBooks = 210;
            int totalShelves = 10;
            int booksPerShelf = totalFatherBooks / totalShelves;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double cristinaTotalCroissants = 17.00;
            double cristinaTotalGuests = 7.00;
            double croissantsPerGuest = cristinaTotalCroissants / cristinaTotalGuests;

            /*
            51. Bill and Jill are house painters. Bill can paint a standard room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 standard rooms?
            Hint: Calculate the rate at which each painter can complete a room (rooms / hour), combine those rates,
            and then divide the total number of rooms to be painted by the combined rate.
            */
            
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace ";
            string middleInitial = "B.";
            string lastName = "Hopper, ";
            string fullName = lastName + firstName + middleInitial;

            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            
        }
    }
}
