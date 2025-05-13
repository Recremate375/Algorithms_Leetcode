namespace Algorithms
{
    public class AddTwoNumbers
    {
        public ListNode SumFunction(ListNode firstNumber, ListNode secondNumber)
        {
            ListNode listNode = new ListNode();
            ListNode currentNode = listNode;
            int sum = 0;
            int carry = 0;

            while (firstNumber != null || secondNumber != null || carry > 0)
            {
                int firstValue = (firstNumber.val != 0) ? firstNumber.val : 0;
                int secondValue = (secondNumber.val != 0) ? secondNumber.val : 0;

                sum = firstValue + secondValue + carry;

                carry = sum / 10;

                currentNode.next = new ListNode(sum % 10);

                currentNode = currentNode.next;

                if (firstNumber != null)
                {
                    firstNumber = firstNumber.next;
                }
                if (secondNumber != null)
                {
                    secondNumber = secondNumber.next;
                }
            }

            return listNode.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
