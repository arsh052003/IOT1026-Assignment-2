using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        /*
            These test methods are checked using manipulate method, which will call the 
            open, close, lock and unlock method depending user action

        */
        [TestMethod]
        public void OpenTest()
        {
            //first treasureChest starts in locked state
            //Creating treasure chest instance with starting state as closed
            TreasureChest treasureChest = new TreasureChest(TreasureChest.State.Closed);
            Assert.AreEqual(TreasureChest.State.Open, treasureChest.Manipulate(TreasureChest.Action.Open));
        }

        [TestMethod]
        public void CloseTest()
        {
            //this test is checking the closed state
            TreasureChest treasureChest = new TreasureChest();
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            treasureChest.Manipulate(TreasureChest.Action.Open);

            // now state is open
            Assert.AreEqual(TreasureChest.State.Closed, treasureChest.Manipulate(TreasureChest.Action.Close));
        }

        [TestMethod]
        public void LockTest()
        {
            // state is locked
            TreasureChest treasureChest = new TreasureChest();
            //change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //change the state to locked
            Assert.AreEqual(TreasureChest.State.Locked, treasureChest.Manipulate(TreasureChest.Action.Lock));
        }

        [TestMethod]
        public void UnlockTest()
        {
            //Testing for unlock action when chest is closed
            TreasureChest treasureChest = new TreasureChest();
            //change the state to closed
            Assert.AreEqual(TreasureChest.State.Closed, treasureChest.Manipulate(TreasureChest.Action.Unlock));
        }

        [TestMethod]
        public void CloseLockedTest()
        {
            //Testing for  invalid action - when trying to close locked chest
            TreasureChest treasureChest = new TreasureChest();
            //Should remain locked and we will display message in output
            Assert.AreEqual(TreasureChest.State.Locked, treasureChest.Manipulate(TreasureChest.Action.Close));
        }

        [TestMethod]
        public void OpenLockedTest()
        {
            //Testing for invalid action - when trying to open locked chest
            TreasureChest treasureChest = new TreasureChest();
            //should remain locked and we will display message in output
            Assert.AreEqual(TreasureChest.State.Locked, treasureChest.Manipulate(TreasureChest.Action.Open));
        }

        [TestMethod]
        public void LockLockedTest()
        {
            //Testing for invalid action - when trying to lock the locked chest
            TreasureChest treasureChest = new TreasureChest();
            //should remain locked and we will display message in output
            Assert.AreEqual(TreasureChest.State.Locked, treasureChest.Manipulate(TreasureChest.Action.Lock));

        }

        [TestMethod]
        public void CloseClosedTest()
        {
            //Testing for invalid action - when trying to close the closed chest
            TreasureChest treasureChest = new TreasureChest();
            // change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //should remain closed and we will display message in output
            Assert.AreEqual(TreasureChest.State.Closed, treasureChest.Manipulate(TreasureChest.Action.Close));
        }

        [TestMethod]
        public void UnlockClosedTest()
        {
            //Testing for invalid action - when trying to unlock the closed chest
            TreasureChest treasureChest = new TreasureChest();
            // change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //should remain closed and we will display message in output
            Assert.AreEqual(TreasureChest.State.Closed, treasureChest.Manipulate(TreasureChest.Action.Unlock));
        }

        [TestMethod]
        public void OpenOpenedTest()
        {
            //Testing for invalid action - when trying to open the opened chest
            TreasureChest treasureChest = new TreasureChest();
            // change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //change the state to opened
            treasureChest.Manipulate(TreasureChest.Action.Open);
            //should remain opened and we will display message in output
            Assert.AreEqual(TreasureChest.State.Open, treasureChest.Manipulate(TreasureChest.Action.Open));
        }

        [TestMethod]
        public void LockOpenTest()
        {
            //Testing for invalid action - when trying to lock the opened chest
            TreasureChest treasureChest = new TreasureChest();
            // change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //change the state to opened
            treasureChest.Manipulate(TreasureChest.Action.Open);
            //should remain opened and we will display message in output
            Assert.AreEqual(TreasureChest.State.Open, treasureChest.Manipulate(TreasureChest.Action.Lock));
        }

        [TestMethod]
        public void UnLockOpenTest()
        {
            //Testing for invalid action - when trying to unlock the opened chest
            TreasureChest treasureChest = new TreasureChest();
            // change the state to closed
            treasureChest.Manipulate(TreasureChest.Action.Unlock);
            //change the state to opened
            treasureChest.Manipulate(TreasureChest.Action.Open);
            //should remain opened and we will display message in output
            Assert.AreEqual(TreasureChest.State.Open, treasureChest.Manipulate(TreasureChest.Action.Unlock));
        }


        [TestMethod]
        public void SetParamTest()
        {
            TreasureChest treasureChest = new TreasureChest(TreasureChest.Material.Oak, TreasureChest.LockType.Novice, TreasureChest.LootQuality.Green);
            Assert.AreEqual("A Locked chest with the following properties:\nMaterial: Oak\nLock Type: Novice\nLoot Quality: Green", treasureChest.ToString());
        }
    }
}
