namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;
        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Oak;
            _lockType = LockType.Novice;
            _lootQuality = LootQuality.Green;
        }
        //assigning values  to material, locktype and lootQuality based on user input
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }
        //changing the state of TreasureChest based on user input
        public TreasureChest(State stChange)
        {
            _state = stChange;

        }

        //retuning the current of state of Treasure 
        public State GetState()
        {
            return _state;
        }

        //Manipulate method accepts Action Parameter and returns the state of the chest
        //
        public State? Manipulate(Action action)
        {
            // switch statement with condition as Action
            switch (action)
            {
                // We will call the appropriate method Open, close, lock or unlock based on Action
                case Action.Open:
                    Open();
                    break;

                case Action.Close:
                    Close();
                    break;

                case Action.Lock:
                    Lock();
                    break;

                case Action.Unlock:
                    Unlock();
                    break;
            }

            //Return state of the chest
            return _state;
        }

        private void Unlock()
        {
            // Using if condition to check the state of the chest
            // if state is locked, then change the state of the chest to closed( Based on state Diagram)
            // if anything else, then print error message using console.writeLine
            if (_state == State.Locked)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("the chest is already unlocked");
            }
            else
            {
                Console.WriteLine("cannot unlock the open chest");
            }
        }

        //when chest is locked, then print the error, otherwise change the state of chest to closed.
        //also check for open chest.
        private void Lock()
        {

            if (_state == State.Locked)
            {
                Console.WriteLine("The chest is allready locked");
            }
            else if (_state == State.Closed)
            {
                _state = State.Locked;
            }
            else
            {
                Console.WriteLine("Chest is open, Please close first");
            }

        }

        //This method is used to open the chest based on the current state of chest and guide us accordingly.(unlock the chest or is already open)
        private void Open()
        {
            if (_state == State.Locked)
            {
                Console.WriteLine("Treasure chest is LOCKED!! Find the key to unlock the chest");
            }
            else if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else
            {
                Console.WriteLine("Chest already opened");
            }
        }

        //This method is used to closed the chest, if already closed it will print message for closed.
        //else close the chest if chest is open.
        private void Close()
        {
            if (_state == State.Closed)
            {
                Console.WriteLine("Chest is already closed");
            }
            else if (_state == State.Open)
            {
                _state = State.Closed;
            }
            else
            {
                Console.WriteLine("Can not close a locked chest");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
