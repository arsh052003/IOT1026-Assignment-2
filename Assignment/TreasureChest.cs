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

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }
        public State GetState()
        {
            return _state;
        }
        public State? Manipulate(Action action)
        {
            switch (action)
            {
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
            return _state;
        }

        private void Unlock()
        {
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
