
Partial Public Class Form2 :   Form
{
    Private Const String accessKeyId = "自分で取得したアクセスキー";
    Private Const String secretKey = "取得したセキュリティコード";
    Private Const String url = "https://ecs.amazonaws.jp/onca/soap?Service=AWSECommerceService41";

    Public Form1()
    {
        InitializeComponent();
    }

    Private void button1_Click(Object sender, EventArgs e)
    {
        BasicHttpBinding binding = New BasicHttpBinding(BasicHttpSecurityMode.Transport);
        binding.MaxReceivedMessageSize = int.MaxValue;

        AWSECommerceServicePortTypeClient client = New AWSECommerceServicePortTypeClient(binding, New EndpointAddress(url));
        client.ChannelFactory.Endpoint.Behaviors.Add(New AmazonSigningEndpointBehavior(accessKeyId, secretKey));

        ItemLookupRequest request = New ItemLookupRequest();

        // ISBN-13は以下を指定
        request.IdType = ItemLookupRequestIdType.EAN;
        request.IdTypeSpecified = true;
        request.SearchIndex = "Books";
        request.ItemId = New string[] { this.textBoxISBN.Text.Trim() };

        // ISBN-10は以下のみ指定すればおｋ
        //request.IdType = ItemLookupRequestIdType.ISBN;
        //request.ItemId = New string[] { this.textBoxISBN.Text.Trim() };

        request.Condition = Condition.All;
        request.ConditionSpecified = true;
        request.MerchantId = "All";
        request.ResponseGroup = New string[] { "Medium" };

        ItemLookup itemLookup = New ItemLookup();
        itemLookup.Request = New ItemLookupRequest[] { request };
        itemLookup.AWSAccessKeyId = accessKeyId;

        ItemLookupResponse response = client.ItemLookup(itemLookup);
        foreach (var item in response.Items[0].Item)
        {
            ItemAttributes attr = item.ItemAttributes;
            String Title = "タイトル：" + attr.Title;
            String Manufacturer = "\r\n出版社：" + attr.Manufacturer.ToString();
            String ISBN = "\r\nISBN-10：" + attr.ISBN;
            String EAN = "\r\nISBN-13：" + attr.EAN;
            String Author = null;

            If (null! = attr.Author)
            {
                foreach (string str in attr.Author)
                {
                    Author = (null == Author) ? "\r\n著者名：" + str : Author += "/" + str;
                }
            }
            Else
            {
                Author = "\r\n著者名：無し";
            }

            this.textBoxDetail.Text = Title + Author + Manufacturer + ISBN + EAN;
            this.textBoxISBN.Clear();
            this.textBoxISBN.Select();
        }
    }
}
End Class