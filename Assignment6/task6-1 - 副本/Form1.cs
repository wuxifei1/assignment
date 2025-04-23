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
            // 初始化数据绑定
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
                editForm.Order = selectedOrder; // 直接传递原订单对象（引用）
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 无需调用 _orderService.updateOrder，因为明细已通过绑定自动更新
                    orderBindingSource.ResetBindings(false); // 刷新界面
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                var selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"确定要删除订单 {selectedOrder.orderId} 吗?", "确认删除",
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
                // 示例：显示当前选中订单的明细
                dgvDetails.DataSource = selectedOrder.details;
            }
        }
    }
}
