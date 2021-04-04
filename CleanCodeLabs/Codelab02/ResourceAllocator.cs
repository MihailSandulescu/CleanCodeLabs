using System;

namespace CleanCodeLabs.Codelab02
{
    public class ResourceAllocator
    {
        public enum SlotCategory : int
        {
            TimeSlot = 1,
            SpaceSlot = 2
        }

        private static readonly int INVALID_RESOURCE_ID = -1;

        public int Allocate(SlotCategory slotCategory)
        {
            int resourceId;

            foreach (SlotCategory category in (SlotCategory[])Enum.GetValues(typeof(SlotCategory)))
            {
                if(category.ToString().Equals(slotCategory.ToString()))
                {
                    resourceId = FindFreeSlot(slotCategory);
                    MarkSlotBusy(slotCategory, resourceId);
                    return resourceId;
                }
            }

            Console.WriteLine("ERROR: Attempted to allocate invalid resource");
            return INVALID_RESOURCE_ID;
        }

        public void Deallocate(SlotCategory slotCategory, int resourceId)
        {
            bool flag = false;

            foreach (SlotCategory category in (SlotCategory[])Enum.GetValues(typeof(SlotCategory)))
            {
                if (category == slotCategory)
                {
                    MarkSlotFree(slotCategory, resourceId);
                    flag = true;
                    break;
                }
            }

            if(!flag)
            {
                Console.WriteLine("ERROR: attempted to free invalid resource");
            }
        }

        private void MarkSlotFree(SlotCategory slotCategory, int resourceId)
        {
            string slotName = slotCategory.ToString()[0..^4];
            Console.WriteLine("{0} slot Marked as free for resourceId = {1}", slotName, resourceId);
        }

        private void MarkSlotBusy(SlotCategory slotCategory, int resourceId)
        {
            string slotName = slotCategory.ToString()[0..^4];
            Console.WriteLine("{0} slot Marked as busy for resourceId = {1}", slotName, resourceId) ;
        }

        private int FindFreeSlot(SlotCategory slotCategory)
        {
            return new Random().Next() * 50 * (int)slotCategory;
        }
    }
}