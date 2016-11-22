using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Book_Selector
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RandomBookGenerator : Page
    {
        public RandomBookGenerator()
        {
            this.InitializeComponent();
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            //Starts a random variable
            Random random = new Random();
            //Starts an array of images so the user can get a random image generated
            Image[] ImageArray = { AboutABoy, AngelasAshes, BlackBeauty, BridgetJonesDiary, BridgetJonesEdgeofReason, BridgetJonesMadAbouttheBoy, CuriousIncidentDogInNight, DarkPlaces, DexterBookSeries, EnidBlytonFamousFiveSeries, EnidBlytonFarawayTree, EnidBlytonMaloryTowers, EnidBlytonSecretSeven, EnidBlytonStClares, EnidBlytonWishingChairSeries, GameOfThronesSeries, GoneGirl, GoSetAWatchman, Hannibal, HungerGamesTrilogy, JKRowlingCasualVacancy, JKRowlingHarryPotterSeries, LifeOfPi, LordOfTheRingsSeries, MichaelOHigginsSnapshots, MySistersKeeper, NarniaBooks, OneDay, Philomena, PsILoveYou, RoaldDahlChocFactory, RoaldDahlFantasticMrFox, RoaldDahlGiantPeach, RoaldDahlMatilda, RoaldDahlTheBFG, StephenKingCarrie, StephenKingCujo, StephenKingDoloresClaiborne, StephenKingIt, StephenKingMisery, StephenKingTheBody, StephenKingTheGirlWhoLovedTomGordon, StephenKingTheGreenMile, StephenKingTheShawshankRedemption, StephenKingUnderTheDome, TheBeanoAnnual, TheBookTheif, TheBoyintheStripedPyjamas, TheButcherBoy, TheDaVinciCodeBookSeries, TheGirlOnTheTrain, TheHost, TheLovelyBones, TheSecretGarden, TheTimeTravelersWife, ToKillAMockingbird, TwilightSeries, WarmBodiesBook };
            //Randomizes the array
            Image RandomImage = ImageArray[random.Next(0, ImageArray.Length)];
            //If the image is BlackBeauty, the Black Beauty image becomes visible along with the details about that book               
            if (RandomImage == AboutABoy)
            {
                AboutABoy.Visibility = Visibility.Visible;
            }
            else if (RandomImage == AngelasAshes)
            {
                AngelasAshes.Visibility = Visibility.Visible;
            }
            else if (RandomImage == BlackBeauty)
            {
                BlackBeauty.Visibility = Visibility.Visible;
            }
            else if (RandomImage == BridgetJonesDiary)
            {
                BridgetJonesDiary.Visibility = Visibility.Visible;
            }
            else if (RandomImage == BridgetJonesEdgeofReason)
            {
                BridgetJonesEdgeofReason.Visibility = Visibility.Visible;
            }
            else if (RandomImage == BridgetJonesMadAbouttheBoy)
            {
                BridgetJonesMadAbouttheBoy.Visibility = Visibility.Visible;
            }
            else if (RandomImage == CuriousIncidentDogInNight)
            {
                CuriousIncidentDogInNight.Visibility = Visibility.Visible;
            }
            else if (RandomImage == DarkPlaces)
            {
                DarkPlaces.Visibility = Visibility.Visible;
            }
            else if (RandomImage == DexterBookSeries)
            {
                DexterBookSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonFamousFiveSeries)
            {
                EnidBlytonFamousFiveSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonFarawayTree)
            {
                EnidBlytonFarawayTree.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonMaloryTowers)
            {
                EnidBlytonMaloryTowers.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonSecretSeven)
            {
                EnidBlytonSecretSeven.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonStClares)
            {
                EnidBlytonStClares.Visibility = Visibility.Visible;
            }
            else if (RandomImage == EnidBlytonWishingChairSeries)
            {
                EnidBlytonWishingChairSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == GameOfThronesSeries)
            {
                GameOfThronesSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == GoneGirl)
            {
                GoneGirl.Visibility = Visibility.Visible;
            }
            else if (RandomImage == GoSetAWatchman)
            {
                GoSetAWatchman.Visibility = Visibility.Visible;
            }
            else if (RandomImage == Hannibal)
            {
                Hannibal.Visibility = Visibility.Visible;
            }
            else if (RandomImage == HungerGamesTrilogy)
            {
                HungerGamesTrilogy.Visibility = Visibility.Visible;
            }
            else if (RandomImage == JKRowlingCasualVacancy)
            {
                JKRowlingCasualVacancy.Visibility = Visibility.Visible;
            }
            else if (RandomImage == JKRowlingHarryPotterSeries)
            {
                JKRowlingHarryPotterSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == LifeOfPi)
            {
                LifeOfPi.Visibility = Visibility.Visible;
            }
            else if (RandomImage == LordOfTheRingsSeries)
            {
                LordOfTheRingsSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == MichaelOHigginsSnapshots)
            {
                MichaelOHigginsSnapshots.Visibility = Visibility.Visible;
            }
            else if (RandomImage == MySistersKeeper)
            {
                MySistersKeeper.Visibility = Visibility.Visible;
            }
            else if (RandomImage == NarniaBooks)
            {
                NarniaBooks.Visibility = Visibility.Visible;
            }
            else if (RandomImage == OneDay)
            {
                OneDay.Visibility = Visibility.Visible;
            }
            else if (RandomImage == Philomena)
            {
                Philomena.Visibility = Visibility.Visible;
            }
            else if (RandomImage == PsILoveYou)
            {
                PsILoveYou.Visibility = Visibility.Visible;
            }
            else if (RandomImage == RoaldDahlChocFactory)
            {
                RoaldDahlChocFactory.Visibility = Visibility.Visible;
            }
            else if (RandomImage == RoaldDahlFantasticMrFox)
            {
                RoaldDahlFantasticMrFox.Visibility = Visibility.Visible;
            }
            else if (RandomImage == RoaldDahlGiantPeach)
            {
                RoaldDahlGiantPeach.Visibility = Visibility.Visible;
            }
            else if (RandomImage == RoaldDahlMatilda)
            {
                RoaldDahlMatilda.Visibility = Visibility.Visible;
            }
            else if (RandomImage == RoaldDahlTheBFG)
            {
                RoaldDahlTheBFG.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingCarrie)
            {
                StephenKingCarrie.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingCujo)
            {
                StephenKingCujo.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingDoloresClaiborne)
            {
                StephenKingDoloresClaiborne.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingIt)
            {
                StephenKingIt.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingMisery)
            {
                StephenKingMisery.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingTheBody)
            {
                StephenKingTheBody.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingTheGirlWhoLovedTomGordon)
            {
                StephenKingTheGirlWhoLovedTomGordon.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingTheGreenMile)
            {
                StephenKingTheGreenMile.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingTheShawshankRedemption)
            {
                StephenKingTheShawshankRedemption.Visibility = Visibility.Visible;
            }
            else if (RandomImage == StephenKingUnderTheDome)
            {
                StephenKingUnderTheDome.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheBeanoAnnual)
            {
                TheBeanoAnnual.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheBookTheif)
            {
                TheBookTheif.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheBoyintheStripedPyjamas)
            {
                TheBoyintheStripedPyjamas.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheButcherBoy)
            {
                TheButcherBoy.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheDaVinciCodeBookSeries)
            {
                TheDaVinciCodeBookSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheGirlOnTheTrain)
            {
                TheGirlOnTheTrain.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheHost)
            {
                TheHost.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheLovelyBones)
            {
                TheLovelyBones.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheSecretGarden)
            {
                TheSecretGarden.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TheTimeTravelersWife)
            {
                TheTimeTravelersWife.Visibility = Visibility.Visible;
            }
            else if (RandomImage == ToKillAMockingbird)
            {
                ToKillAMockingbird.Visibility = Visibility.Visible;
            }
            else if (RandomImage == TwilightSeries)
            {
                TwilightSeries.Visibility = Visibility.Visible;
            }
            else if (RandomImage == WarmBodiesBook)
            {
                WarmBodiesBook.Visibility = Visibility.Visible;
            }

            btnRandom.Visibility = Visibility.Collapsed;

            if (btnRandom.Visibility == Visibility.Collapsed)
            {
                btnSearchAgain.Visibility = Visibility.Visible;
            }
        }

        private void btnSearchAgain_Click(object sender, RoutedEventArgs e)
        {
            AboutABoy.Visibility = Visibility.Collapsed;
            AngelasAshes.Visibility = Visibility.Collapsed;
            BlackBeauty.Visibility = Visibility.Collapsed;
            BridgetJonesDiary.Visibility = Visibility.Collapsed;
            BridgetJonesEdgeofReason.Visibility = Visibility.Collapsed;
            BridgetJonesMadAbouttheBoy.Visibility = Visibility.Collapsed;
            CuriousIncidentDogInNight.Visibility = Visibility.Collapsed;
            DarkPlaces.Visibility = Visibility.Collapsed;
            DexterBookSeries.Visibility = Visibility.Collapsed;
            EnidBlytonFamousFiveSeries.Visibility = Visibility.Collapsed;
            EnidBlytonFarawayTree.Visibility = Visibility.Collapsed;
            EnidBlytonMaloryTowers.Visibility = Visibility.Collapsed;
            EnidBlytonSecretSeven.Visibility = Visibility.Collapsed;
            EnidBlytonStClares.Visibility = Visibility.Collapsed;
            EnidBlytonWishingChairSeries.Visibility = Visibility.Collapsed;
            GameOfThronesSeries.Visibility = Visibility.Collapsed;
            GoneGirl.Visibility = Visibility.Collapsed;
            GoSetAWatchman.Visibility = Visibility.Collapsed;
            Hannibal.Visibility = Visibility.Collapsed;
            HungerGamesTrilogy.Visibility = Visibility.Collapsed;
            JKRowlingCasualVacancy.Visibility = Visibility.Collapsed;
            JKRowlingHarryPotterSeries.Visibility = Visibility.Collapsed;
            LifeOfPi.Visibility = Visibility.Collapsed;
            LordOfTheRingsSeries.Visibility = Visibility.Collapsed;
            MichaelOHigginsSnapshots.Visibility = Visibility.Collapsed;
            MySistersKeeper.Visibility = Visibility.Collapsed;
            NarniaBooks.Visibility = Visibility.Collapsed;
            OneDay.Visibility = Visibility.Collapsed;
            Philomena.Visibility = Visibility.Collapsed;
            PsILoveYou.Visibility = Visibility.Collapsed;
            RoaldDahlChocFactory.Visibility = Visibility.Collapsed;
            RoaldDahlFantasticMrFox.Visibility = Visibility.Collapsed;
            RoaldDahlGiantPeach.Visibility = Visibility.Collapsed;
            RoaldDahlMatilda.Visibility = Visibility.Collapsed;
            RoaldDahlTheBFG.Visibility = Visibility.Collapsed;
            StephenKingCarrie.Visibility = Visibility.Collapsed;
            StephenKingCujo.Visibility = Visibility.Collapsed;
            StephenKingDoloresClaiborne.Visibility = Visibility.Collapsed;
            StephenKingIt.Visibility = Visibility.Collapsed;
            StephenKingMisery.Visibility = Visibility.Collapsed;
            StephenKingTheBody.Visibility = Visibility.Collapsed;
            StephenKingTheGirlWhoLovedTomGordon.Visibility = Visibility.Collapsed;
            StephenKingTheGreenMile.Visibility = Visibility.Collapsed;
            StephenKingTheShawshankRedemption.Visibility = Visibility.Collapsed;
            StephenKingUnderTheDome.Visibility = Visibility.Collapsed;
            TheBeanoAnnual.Visibility = Visibility.Collapsed;
            TheBookTheif.Visibility = Visibility.Collapsed;
            TheBoyintheStripedPyjamas.Visibility = Visibility.Collapsed;
            TheButcherBoy.Visibility = Visibility.Collapsed;
            TheDaVinciCodeBookSeries.Visibility = Visibility.Collapsed;
            TheGirlOnTheTrain.Visibility = Visibility.Collapsed;
            TheHost.Visibility = Visibility.Collapsed;
            TheLovelyBones.Visibility = Visibility.Collapsed;
            TheSecretGarden.Visibility = Visibility.Collapsed;
            TheTimeTravelersWife.Visibility = Visibility.Collapsed;
            ToKillAMockingbird.Visibility = Visibility.Collapsed;
            TwilightSeries.Visibility = Visibility.Collapsed;
            WarmBodiesBook.Visibility = Visibility.Collapsed;

            btnSearchAgain.Visibility = Visibility.Collapsed;

            if (btnSearchAgain.Visibility == Visibility.Collapsed)
            {
                btnRandom.Visibility = Visibility.Visible;
            }
        }

        // Navigate back to MainPage
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
