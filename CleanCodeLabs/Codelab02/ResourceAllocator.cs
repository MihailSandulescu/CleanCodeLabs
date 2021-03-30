using System;

namespace CleanCodeLabs.Codelab02
{
    public class ResourceAllocator
    {
        public enum SlotCategory
        {
            TimeSlot,
            SpaceSlot
        }

        private static readonly int INVALID_RESOURCE_ID = -1;

        public int Allocate(SlotCategory slotCategory)
        {
            int resourceId;
            switch (slotCategory)
            {
                case SlotCategory.TimeSlot:
                    resourceId = FindFreeTimeSlot();
                    MarkTimeSlotBusy(resourceId);
                    break;
                case SlotCategory.SpaceSlot:
                    resourceId = FindFreeSpaceSlot();
                    MarkSpaceSlotBusy(resourceId);
                    break;
                default:
                    Console.WriteLine("ERROR: Attempted to allocate invalid resource");
                    resourceId = INVALID_RESOURCE_ID;
                    break;
            }

            return resourceId;
        }

        public void Deallocate(SlotCategory slotCategory, int resourceId)
        {
            switch (slotCategory)
            {
                case SlotCategory.TimeSlot:
                    MarkTimeSlotFree(resourceId);
                    break;
                case SlotCategory.SpaceSlot:
                    MarkSpaceSlotFree(resourceId);
                    break;
                default:
                    Console.WriteLine("ERROR: attempted to free invalid resource");
                    break;
            }
        }

        private void MarkSpaceSlotFree(int resourceId)
        {
            Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        }

        private void MarkTimeSlotFree(int resourceId)
        {
            Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        }

        private void MarkSpaceSlotBusy(int resourceId)
        {
            Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        }

        private int FindFreeSpaceSlot()
        {
            return new Random().Next() * 100;
        }

        private void MarkTimeSlotBusy(int resourceId)
        {
            Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        }

        private int FindFreeTimeSlot()
        {
            return new Random().Next() * 50;
        }
    }
}