using Order_Management;

namespace task6_1
{
    public partial class Form1 : Form
    {
        private OrderService _orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ��ʼ�����ݰ�
            orderBindingSource.DataSource = _orderService.orders;
            dgvOrders.DataSource = orderBindingSource;
            dgvDetails.DataSource = orderBindingSource;
            dgvDetails.DataMember = "details";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = new OrderEditForm();
            editForm.Order = new Order();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _orderService.addOrder(editForm.Order);
                orderBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                var selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
                var editForm = new OrderEditForm();
                editForm.Order = selectedOrder; // ֱ�Ӵ���ԭ�����������ã�
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // ������� _orderService.updateOrder����Ϊ��ϸ��ͨ�����Զ�����
                    orderBindingSource.ResetBindings(false); // ˢ�½���
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                var selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"ȷ��Ҫɾ������ {selectedOrder.orderId} ��?", "ȷ��ɾ��",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _orderService.removeOrder(selectedOrder.orderId);
                    orderBindingSource.ResetBindings(false);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchCustomer.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                var result = _orderService.orders
                    .Where(o => o.customer.Contains(keyword) || o.orderId.ToString().Contains(keyword))
                    .ToList();
                orderBindingSource.DataSource = result;
            }
            else
            {
                orderBindingSource.DataSource = _orderService.orders;
            }
        }
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && dgvOrders.CurrentRow.DataBoundItem is Order selectedOrder)
            {
                // ʾ������ʾ��ǰѡ�ж�������ϸ
                dgvDetails.DataSource = selectedOrder.details;
            }
        }
    }
}
