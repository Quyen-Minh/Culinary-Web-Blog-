﻿using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Models
{
    public static class JustBlogInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Category category = new Category()
            {
                Id = 1,
                Name = "CÔNG THỨC",
                Description = "Các công thức chế biến món ăn",
                UrlSlug = "blog-about-congthuc"
            };         
            Category category1 = new Category()
            {
                Id = 2,
                Name = "MẸO VẶT",
                Description = "Những điều giúp công việc chế biến món ăn trở nên tuyệt hơn",
                UrlSlug = "blog-about-meovat"
            };

            modelBuilder.Entity<Category>().HasData(category, category1);
            modelBuilder.Entity<Post>().HasData(
                     new Post()
                     {
                         Id = 1,
                         Title = "TỰ LÀM “BÁNH NƯỚNG NHÂN THỊT NGUỘI” KIỂU ANH",
                         ShortDescription = "CỰC DỄ: TỰ LÀM “BÁNH NƯỚNG NHÂN THỊT NGUỘI” KIỂU ANH – Chiếc bánh được nhắc tới trong cuốn truyện trứ danh “Danny nhà vô địch thế giới”…",
                         PostContent = "Đây là chiếc bánh rất “nặng” – giàu dinh dưỡng, giàu năng lượng, ngon nhất khi ăn ngay vừa ấm nóng còn giòn tan sau khi để bánh nghỉ khoảng 15p sau khi nướng. Hãy ăn nó khi bạn thật đói, bạn sẽ cảm nhận được những gì Danny đã cảm nhận. Nó thật sự là ngon tuyệt!\r\nDụng cụ:\r\nChày cán bột, có thể thay bằng chai thủy tinh tròn (chai rượu).\r\nKhuôn/khay bánh vuông/tròn/chữ nhật khoảng 20-23cm. Nếu không có, hoàn toàn có thể thay bằng khay thủy tinh chịu nhiệt, đĩa sâu lòng.\r\nNguyên liệu:\r\n1 miếng bộ ngàn lớp (500g bạt puff pastry)\r\n1 gói 200g-225g thịt nguội (thịt vai xông khói – ham)\r\n10 quả trứng gà ta hoặc 7 quả trứng gà công nghiệp (gà ta sẽ ngon hơn nhiều)\r\n1 nhúm hành lá thái nhỏ\r\n100g phomai Parmesan (hoặc them phomai mozzarella nếu bạn thích)\r\nTiêu bột\r\n(mình không thêm muối vì thích dùng nhiều phomai nên đã mặn sẵn)\r\nPhủ bánh:\r\n1 trứng (trong số trứng trên)\r\n1 thìa to sữa tươi\r\n30g phomai Parmesan (trong số phomai trên)\r\nBạt ngàn lớp (puff pastry) mình dùng loại đông lạnh mua sẵn, bạn có thể đặt mua online tại Annam Gourmet hoặc bất cứ tiệm nào có bán. Mình đặt của bạn Chef @Nguyễn Văn Khu – một đầu bếp bánh cũng là YBer. Mình thường mua 1-2 cân trữ sẵn ngăn đá cùng rất tiện, có thể làm được nhiều loại bánh lắm.\r\nCách làm mình chia sẻ trong từng hình nha.\r\nĐây là “chân dung” chiếc bánh nướng thịt nguội “tuyệt vời nhất, đẹp đẽ nhất thế gian này” của Danny. Lớp vỏ giòn tan vàng rộm toàn bộ đang tỏa mùi thơm nức. Miếng thịt màu hồng tươi và mềm không dính chút mỡ hay sụn nào, đôi chỗ còn có những quả trứng đã được chín kĩ lấp ló như thể kho báu chôn dưới đất vậy.",
                         Published = true,
                         UrlSlug = "Post1",
                         PostedOn = DateTime.Now,
                         Modified = DateTime.Now,
                         CategoryId = 1,
                         Image = "post1.jpg"
                     },
                    new Post()
                    {
                        Id = 2,
                        Title = "CÁCH LÀM BÁNH MÌ THANH LONG NHÂN KEM CHEESE/ THƠM ĐẸP KHÔNG MẤT MÀU",
                        ShortDescription = "Tổng kết “Hot trend Yêu Bếp” CÁCH LÀM BÁNH MÌ THANH LONG NHÂN KEM CHEESE/ THƠM ĐẸP KHÔNG MẤT MÀU (Bài dài nhưng cách làm rất dễ) Công cuộc giải cứu thanh long hỗ trợ nông dân Việt Nam ghi…",
                        PostContent = "Trước hết, ta cần biết, sắc tố đỏ trong ruột thanh long là do nó chứa lượng lớn chất màu betacyanin, là nhóm sắc tố tự nhiên chứa nitơ và tan trong nước. Lượng betacyanin này tăng theo mức độ chín của quả. Tổng lượng betacyanin lúc chín của quả thanh long ruột đỏ từ 32 đến 47 mg/100g thịt quả. Vì vậy, muốn màu càng đỏ đẹp, đầu tiên ta cần chọn quả chín thật kỹ, vỏ mỏng, căng, tai quả ngả xanh, cần quả lên chín nặng mọng nước.\r\nTuy nhiên, trong quá trình chế biến và bảo quản, chất màu betacyanin trong thanh long sẽ dần bị phân hủy. Sự ổn định của hợp chất màu betacyanin này bị ảnh hưởng lớn nhất bởi nhiệt, oxy trong không khí, ánh sáng, độ pH mà nó tiếp xúc và độ ẩm. Các kích thích của ánh sáng dẫn đến khả năng phản ứng cao hơn hoặc giảm năng lượng hoạt hóa của phân tử. Bên cạnh đó, betacyanin cũng rất dễ bị oxy hoá khi có mặt trong các sản phẩm có hàm lượng nước cao hoặc chứa các ion kim loại (ví dụ như Fe3+ hay Cu2+).\r\nVì vậy, ta sẽ phân tích và tìm được cách giữ màu thanh long đẹp nhất khi làm bánh mì thành long:\r\n1. Nhiệt độ/thời gian gia nhiệt giữ màu thanh long tự nhiên dạng lỏng đẹp nhất là nhiệt độ khử trùng từ 70 – 90 độ C, thời gian tối ưu là 15p, không phù hợp nướng bánh mì. Vì vậy, phải chọn công thức bánh mì cốt bơ, ủ men chậm nhất có thể (ít men, nếu có men tự nhiên thì tốt nhất) để có thể giảm nhiệt độ và thời gian nướng, cũng như tạo hình phù hợp để nướng được nhanh nhất có thể. Tối ưu nhất là phân tách lớp ruột bánh bởi một nhân đã chín, dẫn nhiệt tốt giữa các lớp bột bánh. Vì vậy, mình đã nghiên cứu để thêm nhân kem cheese với công thức bánh mì bơ cơ bản giúp bánh chín từ trong nhanh, giảm thời gian nướng.\r\n2. Giảm yếu tố khiến betacyanin trong thanh long bị oxi hoá mất màu bởi oxi, ánh sáng, độ Ph và độ ẩm:\r\n– Càng lỏng, betacyanin càng dễ mất màu. Chỉ phù hợp làm công thức bánh mì không thêm chất lỏng, đặc biệt là không thêm sữa, nước.\r\n– Ánh sáng: Ảnh hưởng không nhiều do quá trình làm bánh chỉ vài tiếng trong ngày ở ánh sáng tự nhiên, mùa này ở HN.\r\n– Dùng chất chống oxi hoá tự nhiên giảm quá trình oxi hoá mất màu betacyanin trong thanh long: Trong các chất chống oxi hóa tự nhiên, có thể bảo vệ màu bằng cơ chế chống các tác nhân oxi hóa để có tác dụng việc duy trì màu betacyanin, thì ta thấy có acid ascorbic là một hợp chất sáu carbon liên quan đến glucose. Nó được tìm thấy tự nhiên trong trái cây và nhiều loại rau. Dạng hoạt tính sinh học của nó, chính là vitamin C đó ạ. Nó hoạt động như một chất khử và coenzyme trong một số con đường trao đổi chất. Vì vậy, Vitamin C được coi là một chất chống oxy hóa. Khi có các tác nhân oxi hóa, thì acid ascorbic sẽ thay thế betacyanin phản ứng trước, như một “chiến sĩ cảm tử bảo vệ”, vì vậy nó sẽ làm nguyên vẹn hoặc hạn chế phản ứng oxi hóa của hợp chất màu trong thanh long. Tuy nhiên, nồng độ acid ascorbic mà ta cần bổ sung cũng có ảnh hưởng đáng kể đến độ bền màu betacyanin trong quá trình chế biến. Nếu quá ít, không đủ giữ, nếu quá nhiều, ảnh hưởng đến mùi vị của sản phẩm. Vì vậy, qua quá trình thử nghiệm, mình tìm được cách dùng nước cốt chanh leo là dạng tự nhiên có đủ acid ascorbic ở nồng độ vừa đủ, lại giúp bánh có mùi vị thơm ngon hơn, hoàn toàn phù hợp với bánh mì thanh long, với tỉ lệ sẽ chia sẻ trong công thức.\r\n– Ngoài ra, độ PH của bất cứ chất lỏng nào mà betacyanin tiếp xúc cũng ảnh hưởng đến quá trình oxi hoá của betacyanin. Độ PH của nước tốt nhất mà betacyanin tiếp xúc là độ PH 4.0 (nước axit nhẹ) – theo Wong and Siow ( tài liệu nghiên cứu năm 2015) là tác giả nghiên cứu mà mình tự học. May mắn là nhà mình dùng máy lọc nước tạo ion kiềm của Cleansui tại nhà nên nhà mình lúc nào cũng có sẵn nước có độ PH 4.0, để mình ăn uống, tìm hiểu ẩm thực và chăm sóc sức khoẻ ạ. Nếu không có, trong công thức mình cũng có hướng dẫn rồi nhé.\r\nNước có độ PH 4.0 sẽ được xịt lên mặt bánh trước và trong quá trình nướng, giúp hạn chế nhất việc mất màu do nhiệt của quá trình nướng. Đây là một mẹo tuyệt vời mà bạn có thể áp dụng khi nướng các loại bánh ở nhiệt độ cao mà dùng màu tự nhiên như màu đỏ lá cẩm, màu đỏ gấc, màu củ dền v.v… ạ.\r\nVì vậy, mình tổng hợp công thức và cách làm phù hợp mà mình đã nghiên cứu dựa trên công thức bạn Bích Ngọc chia sẻ trên Yêu Bếp, đóng góp các thử nghiệm đã thành công của mình để giữ màu đẹp, với nhân kem phomai cực ngon, các bạn làm thử nhé!\r\nCách làm từng bước chi tiết theo từng ảnh nha!\r\nBánh mì thanh long nhân kem phomai có chất ruột siêu mềm, dai sợi từng thớ thơm nức. Vỏ bánh mới nướng sẽ mỏng giòn tan, quyện với lớn nhân kem cheese siêu ngậy béo sẽ khiến bạn tan chảy… tan chảy…. Đặc biệt là với những kẻ nghiện kem cheese như mình.",
                        Published = true,
                        UrlSlug = "Post2",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post2.jpg"

                    },
                    new Post()
                    {
                        Id = 3,
                        Title = "BULGOGI PIZZA (PIZZA VỊ THỊT BÒ NƯỚNG KIỂU HÀN QUỐC)",
                        ShortDescription = "Đây là công thức pizza rất phù hợp để nướng chảo vì toàn bộ phần topping đã được làm chín sẵn. Pizza nướng chảo không hề khó, thậm chí còn rất dễ và ngon, có điều bạn cần chọn cho…",
                        PostContent = "I. Phần đế Pizza:\r\nNguyên liệu: Dành cho 2 đế bánh cỡ chảo 26cm (mình dùng chảo chống dính Ecook của Lock&Lock)\r\n• 150ml sữa ấm (~40 độ C).\r\n• 1/2 teaspoon đường,\r\n• 1/2 tablespoon men nở khô (instant yearst)\r\n• 1/2 tablespoon dầu oliu,\r\n• 250g bột làm bánh mì (bread flour)\r\n• 1/4 teaspoon muối.\r\nCách làm:\r\n– Cho đường vào sữa ấm, quấy tan. Thả men vào, quấy nhe. Đợi 3-5 phút cho men nở bùng lên. Cho dầu ăn vào nước men, quấy đều.\r\n– Trộn đều bột bánh mì và muối trong một tô lớn. Tạo hố, rót dần nước men vào, trộn đều rồi dùng tay nhào nhẹ đến khi bột thành một khối.\r\n– chuyển khối bột ra mặt phẳng sạch, dùng tay nhào cho bột mịn đều, không dính tay (5 phút). Chia bột làm 2 phần, viên tròn. Cho bột vào tô có phết 1 lớp mỏng dầu ăn, bọc kín bằng màn bọc thực phẩm. Ủ bột khoảng 30-45p cho đến khi bột nở gấp đôi, ấn ngón tay không thấy đàn hồi.\r\n– Đặt bột lên mặt phẳng đã có bột áo, ấn dẹt rồi dùng chày cán bột cán thật mỏng. Ta được đế tươi chuẩn bị làm pizza bulgogi. Trong thời gian chờ ủ bột, ta làm sốt và topping bulgogi.\r\n\r\nII. Sốt cà vị gochujang kiểu HQ cho 2 bánh chảo 25cm:\r\n– 5 tbsp tương cà (mình dùng tương cà đóng chai của Heinz)\r\n– 2 tbsp đường\r\n– 3 tbsp dầu mè\r\n– 2 tbsp tương ớt đỏ HQ Gochujang\r\nTrộn đều tất cả nguyên liệu trong tô, khuấy cho tan bớt đường.\r\n\r\nIII. Topping bulgogi cho 2 bánh chảo 25cm:\r\nNguyên liệu:\r\n– 200g phomai mozarrella\r\n– 200g thịt bò thăn, thái lát mỏng\r\n– ½ của hành tây\r\n– 1 nhánh tỏi tây/hành boa-rô\r\n– 1 khúc cà rốt dài khoảng 6cm\r\nPhần nước ướp:\r\n– 1 miếng lê nhỏ (1/4 quả)\r\n– 1 tsp tỏi nghiền\r\n– 2 tbsp xì dầu\r\n– 2 tbsp đường nâu\r\n– 1 tbsp dầu mè\r\n– 1 tbsp mè trắng rang vàng\r\nCách làm:\r\nBào phomai thành sợi nhỏ, để riêng.\r\nHành tây, cà rốt, phần cọng xanh hành boa rô thái sợi nhỏ. Phần cọng trắng bằm nhuyễn.\r\nLê nghiền/xay. Trộn toàn bộ nguyên liệu nước ướp với nhau quấy tan đường rồi ướp với thịt bò và hành tây, cà rốt, hành boa-rô. Ướp khoảng 15 trong lúc chờ bột nở. Bắc chảo xào lên bếp bật to lửa. Cho thịt vào xào chín, thịt chín mềm thì gắp trước thịt ra, giảm nhỏ lửa đến khi ướp ướp sệt lại thì cho lại thịt vào đảo qua cho thấm.",
                        Published = true,
                        UrlSlug = "Post3",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post3.jpg"
                    },
                    new Post()
                    {
                        Id = 4,
                        Title = "KẸO HẠT DẺ PHÁP – MÓN TRÁNG MIỆNG CỰC PHẨM MÀ VUA LOUIS XIV YÊU THÍCH",
                        ShortDescription = "KẸO HẠT DẺ PHÁP – MÓN TRÁNG MIỆNG CỰC PHẨM MÀ VUA LOUIS XIV YÊU THÍCH Ngay khi nhìn thấy những rổ hạt dẻ mùa thu siêu to siêu ngon tại khu chợ Haeundae ở Busan Hàn Quốc, mình đã…",
                        PostContent = "Đầu tiên là tìm cách lột sạch vỏ hạt dẻ sống. Công đoạn gây nản nhất trên đời.\r\nTiếp theo, vì không thể xuyên không về 300 năm trước để có được công thức của thợ làm kẹo Pháp, nên mình chỉ còn cách vận dụng kiến thức hoá học và sinh học thực phẩm để nắm được đặc tính của đường ở các độ quá bão hòa khác nhau, hiểu rõ động học của quá trình kết tinh đường rồi từ đó tính ra điểm bão hoà tinh thể đường khi nấu cùng hạt dẻ.\r\nCuối cùng, phải quan sát dung dịch quá bão hòa ảnh hưởng đến sự tạo mầm tinh thể thế nào để tính toán đúng tỉ lệ đường phù hợp với lượng nước và lượng hạt dẻ mà mình đã dùng.\r\nSao cho mỗi hạt dẻ đều được ngấm dần từng chút đường. Mục đích là sau 10 ngày nấu kẹo, mỗi viên hạt dẻ đều không hề vỡ nát, cũng không bị biến cứng bề mặt.\r\nMỗi viên đều phải mềm tan trong miệng, ngấm đẫm lớp mật hạt dẻ đã ngào kỹ với đường, thơm nức mùi rượu, mùi vanilla và đường ngào. Vừa bùi thơm vừa ngọt ngào mềm mại!\r\nCông đoạn thử thách đầu tiên: bóc vỏ hạt dẻ sống.\r\nPhải tách bỏ lớp vỏ cứng bên ngoài mà không được nấu chín hạt dẻ.\r\nĐịnh hình trước khi nấu kẹo.\r\nMọi tỉ lệ đều cần chính xác để kẹo đạt được sự hoàn hảo về mùi vị, màu sắc & kết cấu (texture), hình dáng.\r\nNước surup hạt dẻ, sóng sánh đặc lại sau từng ngày nấu.",
                        Published = true,
                        UrlSlug = "Post4",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post4.jpg"
                    },
                    new Post()
                    {
                        Id = 5,
                        Title = "[GÓC BẾP THƠM BƠ] BÁNH MUFFIN TÁO QUẾ PHỦ GIÒN CHO MÙA ĐÔNG ẤM SỰC",
                        ShortDescription = "[GÓC BẾP THƠM BƠ] BÁNH MUFFIN TÁO QUẾ PHỦ GIÒN CHO MÙA ĐÔNG ẤM SỰC Tự dưng nhớ lại những kỉ niệm sâu sắc của nhiều năm trước, khi hôm nay, bàn tay mình vương mùi bơ chảy thơm tho…",
                        PostContent = "Cách làm cực kì đơn giản. Vì kĩ thuật bánh này khá dễ. Chỉ cần lựa chọn nguyên liệu tươi ngon và một loại mùi vị mà bạn yêu thích. Như vị táo xanh & bột quế cho mùa đông ấm sực chẳng hạn.\r\nChọn táo xanh Granny Smith thì nướng lên sẽ rất giòn và có vị chua dịu cân bằng với độ ngọt của bánh. Bột quế thì dùng bột quế của Việt Nam là thơm ngon nhất nha.\r\nMột nguyên liệu quan trọng cho loại bánh này là bơ. Bạn nên dùng bơ lạt để mùi vị bánh được cân bằng.\r\nThông thường, các loại bánh với bơ sẽ dễ bị cứng lại khi để qua ngày (thời điểm bánh nghỉ tốt nhất), đặc biệt vào mùa đông. Đôi khi chỉ ngon khi được làm nóng lại.\r\nĐể làm muffin ngon, mềm xốp và thơm nức thì mẹo nhỏ của mình là chọn được bơ lạt thật ngon. Sẽ giúp bánh muffin để ngoài nhiệt độ phòng vẫn mềm mại, lớp phủ giòn giữ được giòn rất lâu và thơm ngon.\r\nBơ lạt vừa là nguyên liệu quan trọng trong làm bánh, vừa là nguồn dinh dưỡng cung cấp protein dồi dào. Một mẻ bánh vừa ngon, vừa bổ dưỡng cho bọn trẻ cứ gọi là mê tít ❤\r\nMình dùng bơ COOK & BAKE của Emborg – một loại bơ nhạt được kết hợp từ bơ động vật và dầu thực vật, giá thành khá là mềm mà bạn có thể tìm thấy ở các siêu thị. Mình siêu thích bơ này vì mùi thơm dịu không bị mùi gây mạnh khi làm lớp phủ giòn, vị ngậy vừa độ và giữ được độ mềm cho bánh cả ở thời tiết lạnh. Bơ lạt COOK & BAKE của Emborg xuất xứ Châu Âu, trong bài mình có chụp hình loại bơ này luôn để các bạn dễ hình dung.\r\nGiờ thì cùng làm thử nha!\r\nNguyên liệu đơn giản, làm được tận 14-15 bánh nhá.\r\n1. Lớp phủ giòn:\r\n• 70g đường nâu\r\n• 1 Tbsp đường kính\r\n• 1 tsp bột quế\r\n• 60g bơ lạt Cook & Bake\r\n• 85g bột mì đa dụng\r\n2. Cốt Muffin:\r\n*Hỗn hợp A (bột khô)\r\n• 220g bột mì đa dụng\r\n• 1 tsp muối nở (baking soda)\r\n• 1 tsp bột nở (baking powder)\r\n• 1 tsp bột quế\r\n• ½ tsp muối\r\n*Hỗn hợp B (bột ướt)\r\n• 120g bơ lạt Cook & Bake\r\n• 150g đường nâu\r\n• 2 quả trứng\r\n• 120g sữa chua không đường\r\n• 2 tsp tinh chất vanilla\r\n• 60ml sữa không đường\r\n• 2 quả táo xanh nhỏ vừa\r\n3. Đường phủ (Icing Sugar)\r\n• 120g đường bột\r\n• 3 Tbsp whipping cream\r\n• ½ tsp vanilla\r\nMình chia sẻ chi tiết trong từng ảnh nhé!\r\nVà còn một phiên bản hướng dẫn bằng zidéo trên kênh Tóp Tóp cực mượt mắt, hình ảnh phát ra mùi thơm bơ luôn, bạn “thùy link” trợ lý của mình đây: https://vt.tiktok.com/ZSRKEKknQ/\r\nGiờ thì bắt tay làm thôi!!!\r\nNếu được chọn một món bánh đơn giản cho mùa đông ấm sực thì chắc chắn mình sẽ chọn muffin táo quế – món bánh ngon lành mà bất cứ ai cũng có thể làm thành công ngay từ lần đầu tiên.",
                        Published = true,
                        UrlSlug = "Post5",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post5.jpg"
                    },
                    new Post()
                    {
                        Id = 6,
                        Title = "GIẢI MÃ CÁCH LÀM TRỨNG “OSMANTHUS” (TRỨNG 3 KHÔNG DÍNH) MÀ VUA CÀN LONG CỰC YÊU THÍCH",
                        ShortDescription = "GIẢI MÃ CÁCH LÀM TRỨNG “OSMANTHUS” (TRỨNG 3 KHÔNG DÍNH) MÀ VUA CÀN LONG CỰC YÊU THÍCH Bạn đã từng nghe đến món trứng vi diệu, đã từng được tôn là “công phu thượng thừa” của đầu bếp TQ mà…",
                        PostContent = "Đây là món ăn với nguyên liệu cực dễ kiếm, chỉ có:\r\nNguyên liệu\r\n• 6 lòng đỏ trứng\r\n• 80gr đường\r\n• 50gr bột năng\r\n• 1 nhúm muối tinh\r\n• 200ml nước\r\n• 1 tsp tinh chất vani (nếu có)\r\n• 1-2 Tbsp dầu ăn\r\nNhưng để làm được một đĩa bánh trứng có “phép thuật” như vậy lại cần đến các kĩ thuật cao thủ của một người đầu bếp cung đình, sao cho trứng bóng mượt, mịn dẻo, hoàn toàn không vón cục hay dính chảo.\r\nNhưng có một điều Càn Long thật không ngờ rằng 100 năm sau vật đổi sao dời! Phương Tây đã phát minh ra bếp ma thuật không cần canh lửa và chảo thần kì chiên rán gì cũng không dính nên bất cứ thường dân nào cũng có thể tự làm được món này! 😅😂😂 Mình tin là sau khi đọc bài này, bạn cũng làm được đó!\r\nChỉ cần nắm rõ bí kíp & các mẹo nhỏ như trong video mới nhất mình đã chia sẻ trên kênh Tóp Tóp Yêu Bếp là làm được ngay. Link mình thả trong còm men nha!\r\nHãy cũng tham gia Thử thách “Sống Yêu Đời” cùng Yêu Bếp bằng làm thử món bánh trứng Osmanthus này rồi đăng tải lên kênh TikTok của bạn với các hashtag như sau: #SốngYêuĐời #YêuBếp #HafeleVietnam #Giaiphapsongtoandien\r\nNgoài ra, một gợi ý hay ho là bạn có thể dùng chức năng STITCH của TikTok để lồng ghép tự động video của bạn với video gốc của mình để video thêm phần thú vị, dễ dàng khi quay dựng!!! Nếu bạn chưa biết đến chức năng STITCH này, cứ comment hỏi mình nha!!!\r\nGiờ thì lượn một vòng tìm hiểu thêm về món trứng Osmanthus trứ danh này qua hình ảnh mình đã thực hiện món này nhé.\r\nBánh trứng Osmanthus hay còn gọi là Bánh trứng 3 Không Dính: Sanbuzhan (三不沾)\r\n\r\nMột món ăn chứa đựng rất nhiều sự tích thú vị được tương truyền trong lịch sử TQ, nhưng nguyên liệu lại rất quen thuộc dễ kiếm.",
                        Published = true,
                        UrlSlug = "Post6",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post6.jpg"
                    },
                    new Post()
                    {
                        Id = 7,
                        Title = "CUỐI TUẦN LÀM BÁNH MÌ “LƯỜI” SIÊU CẤP VÔ ĐỊCH /Bữa sáng ngon lành ấm sực lại nhanh thần tốc/",
                        ShortDescription = "CUỐI TUẦN LÀM BÁNH MÌ “LƯỜI” SIÊU CẤP VÔ ĐỊCH /Bữa sáng ngon lành ấm sực lại nhanh thần tốc/ Chờ mãi cũng đến cuối tuần, mai lại còn Giáng Sinh nữa chứ. Chần chừ gì mà chưa tự thưởng…",
                        PostContent = "Cách làm thì dễ tới mức bất cứ ai cũng có thể làm được, kể cả là người “lười” nhất quả đất này hay các bạn nhỏ tập làm bánh ở nhà cũng có thể thành công ngay từ lần đầu tiên.\r\nKhông cần dụng cụ cân đong phức tạp.\r\nKhông cần máy móc lò nướng chuyên nghiệp\r\nKhông cần hoa tay\r\nVà quan trọng nhất, là không ngon không lấy tiền!!\r\nNGUYÊN LIỆU:\r\n– 5 lát bánh mì gối đen/ trắng\r\n– 3 quả trứng gà\r\n– 2 Tbsp sữa tươi không đường\r\n– 3 miếng phô mai con bò cười\r\n– 50g chà bông Đài Loan\r\n– 30g rong biển rắc cơm\r\n– Hành lá thái nhỏ, tùy khẩu vị.\r\n– 4 lòng đỏ trứng muối (tùy thích)\r\nĐầu tiên là làm nóng lò nướng hoặc NCKD trước nhé.\r\nSau đấy thì đập trứng gà ra bát này.\r\n Sau đấy thì thêm sữa tươi không đường và đánh cho tan.\r\nBánh mì gối bạn cắt thành hình vuông như quân cờ rồi rưới phần trứng đánh sữa lên\r\nTrộn thật đều cho bánh mì ngấm trứng và mềm dần.",
                        Published = true,
                        UrlSlug = "Post7",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post7.jpg"
                    },
                    new Post()
                    {
                        Id = 8,
                        Title = "CÁCH LÀM “LẨU” BÁNH MÌ XÍU MẠI TRỨNG MUỐI CHẢ CUA",
                        ShortDescription = "CÁCH LÀM “LẨU” BÁNH MÌ XÍU MẠI TRỨNG MUỐI CHẢ CUA Nhớ Đà Lạt quá chả biết làm thế nào, đành vào bếp làm một nồi lẩu xíu mại trứng muối và chả cua sôi lục bục toả mùi thơm…",
                        PostContent = "Nguyên liệu cho phần xíu mại (4-5 người ăn)\r\nSẽ được 10 viên trứng muối, 10 viên không trứng\r\n700 thịt xay (chọn thịt vai giòn có mỡ dắt)\r\n1 miếng bì heo nhỏ (xin thêm hàng thịt khi mua thịt)\r\n1/2 củ đậu (củ sắn) to vừa\r\n1 quả trứng gà\r\n1/2 ổ bánh mì\r\n1/2 củ hành tây băm nhỏ\r\n1 mẩu cà rốt băm nhỏ\r\n3 củ hành khô băm nhỏ\r\n1 củ tỏi băm nhỏ\r\nRau thơm, mùi ta (ngò rí), hành lá xắt nhuyễn\r\n2 Tbsp nước mắm\r\n1/2 tsp muối\r\n1 tsp đường\r\n1 Tbsp Dầu mè\r\n1 tsp Tiêu\r\n10 lòng đỏ Trứng muối\r\n🍑 Phần nước dùng:\r\nXương gà 1 hộp (1 bộ)\r\nPhần da heo cắt miếng đã để lại\r\n½ tsp muối\r\n1 tsp nước mắm\r\n3 củ Hành tím + 3 tép tỏi + 1 lát gừng băm nhỏ\r\n5 quả Cà chua\r\n3 Tsbp tương cà (Ketchup)\r\n3 Tbsp bột năng",
                        Published = true,
                        UrlSlug = "Post8",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post8.jpg"
                    },
                    new Post()
                    {
                        Id = 9,
                        Title = "[Mùa Vu Lan Tháng 7] CÁCH LÀM PATE CHAY VỪA NGON VỪA DỄ",
                        ShortDescription = "Mùa Vu Lan Tháng 7] CÁCH LÀM PATE CHAY VỪA NGON VỪA DỄ + Không cần rang hạt (giữ độ béo, kết dính cho pate) + Không cần hấp pate, không cần nướng cách thuỷ + Làm từ bánh mì…",
                        PostContent = "Nguyên liệu để làm patechay mịn mượt thơm nức nè:\r\n100g hạt điều tươi\r\n300g nấm đùi gà tươi\r\n1 bìa đậu phụ (đậu hũ)\r\n4 lát nhỏ bánh mì đen Sourdough (mình tận dụng gom lại các đầu mẩu hàng ngày ăn còn thừa, để ngăn đá rồi làm món chay mỗi khi mình đặt bánh này mà không ăn hết).\r\n100g bơ lạt (có thể thay bằng bơ thực vật)\r\n4 tép tỏi bằm nhỏ (không ăn bỏ qua)\r\n1 nắm nhỏ đầu hành trắng bằm nhỏ (không ăn bỏ qua)\r\n4 thìa to nước tương (mình dùng nước tương Kikkoman). Tuỳ khẩu vị và độ mặn của loại nước tương bạn dùng, có thể gia giảm cho vừa miệng nhé.\r\nMuối: mình không dùng thêm muối vì mẹ mình cần ăn nhạt, bạn có thể gia giảm cho vừa khẩu vị ở bước cuối.\r\n¼ thìa nhỏ tiêu bột.\r\n1 thìa nhỏ bột cacao nguyên chất (không đường) để tạo màu.\r\nPate đổ từ khuôn ra rất đứng hình, rất mịn mượt và lớp nấm mềm bên trên phải dính chắc, không bị long ra nha.\r\nNguyên liệu tạo mùi vị thơm ngon đặc biệt của món này là những mẩu “đầu thừa đuôi thẹo” của ổ bánh mì Sourdough mỗi ngày mình ăn mà còn hoặc không muốn ăn phần vỏ cứng thì bỏ lại vào 1 cái hộp kín để ngăn đá. Khi nào làm đồ chay thì mang ra làm.\r\nnấm sạch hút chân không, khi dùng không rửa lại với nước để nấm khô xốp (bản thân nấm sạch đủ để không phải rửa lại). Thái nhỏ 200g để xào, 100g còn lại thái lát mỏng nhé!\r\nCách làm:\r\nLuộc hạt điều tươi với 200ml nước ở lửa nhỏ cho đến khi hạt điều nở mềm (khoảng 15p). Vớt hạt điều ra cho nguội, giữ lại nước luộc hạt điều\r\nBánh mì đen xé nhỏ, ngâm vào nước luộc hạt điều cho nở mềm\r\nDùng thìa nghiền nhuyễn đậu phụ.\r\nCho bơ vào chảo nóng. Nên dùng chảo không chống dính để tạo mùi xém chảo. Cho hành tỏi vào phi thơm hơi xém vàng.\r\nCho hạt điều vào xào thấm đều bơ.",
                        Published = true,
                        UrlSlug = "Post9",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post9.jpg"
                    },
                    new Post()
                    {
                        Id = 10,
                        Title = "CÁCH LÀM HẠT ĐÁC RIM DỨA & CHANH LEO HOT TREND MÙA HÈ",
                        ShortDescription = "CÁCH LÀM HẠT ĐÁC RIM DỨA & CHANH LEO HOT TREND MÙA HÈ Mẹo rim hạt đác giòn dẻo, giữ màu vàng tươi óng đẹp. Ngoài kem, chè hay nước uống giải khát thì có gì ngon mát để ăn…",
                        PostContent = "Mời bạn đọc hết bài chia sẻ này của mình, đảm bảo ngon “cháy phố” luôn.\r\nHạt đác có vị ngọt thanh, tính lành mát, ít calories nên chẳng lo tăng cân. Còn trong các loại trái cây như dứa, chanh leo ngoài hương vị thơm ngon thì còn cung cấp siêu nhiều chất xơ, khoáng chất, đặc biệt là các loại vitamin dưỡng cho da dẻ tươi tắn \r\nĐi chợ với Yêu Bếp thôi:\r\n• 1 kg hạt đác tươi (cho cả 2 vị)\r\n• 350 gram đường kính (cho cả 2 vị)\r\n• 1 quả dứa to\r\n• 6 quả chanh leo (tùy khẩu vị)\r\nĐể rác có màu bóng đẹp, “chewy” thì bí quyết của mình là nên rim đác bằng một cái chảo to và chống dính thật tốt. Chảo to vừa rim được mẻ đác nhiều hơn, tiết kiệm thời gian mà lại dễ dàng khuấy, đảo nữa. Dùng chảo có lớp chống dính tốt thì nhiệt độ sẽ đồng đều, đác khi rim xong vẫn giữ được màu tươi của hoa quả, không bị thâm xỉn.\r\nRim đác đẹp nhờ chảo là có thật đấy các bạn ạ! Dùng qua cả loạt chảo các loại, thì mình vẫn ưng ý chảo xào này của Fika nhất, lòng chảo rộng, chống dính cực đỉnh, các bạn có thể tham khảo nhé. Chảo size 26cm cân cả buồng đác chứ đùa, mấy món rim, hay sên mứt cần nhiều thời gian là kiểu gì cũng dùng cái chảo xào này hết á. Chảo to đi kèm vung thủy tinh viền silicone siêu kín, nấu món xào âm ỉ nhiệt thì best luôn. Còn về “ngoại hình” thì khỏi bàn, đúng màu kem tui thích, y hệt chảo mấy bạn hot girl hướng dẫn nấu ăn chill chill trên TikTok.\r\n",
                        Published = true,
                        UrlSlug = "Post10",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post10.jpg"
                    },
                    new Post()
                    {
                        Id = 11,
                        Title = "CÁCH LÀM KOMBUCHA ĐÀO “LƯỜI”",
                        ShortDescription = "CÁCH LÀM KOMBUCHA ĐÀO “LƯỜI” Mùa thu, tranh thủ một năm thời tiết ẩm ương, Trung Thu vẫn còn những trái xuân đào cuối vụ, mình làm một mẻ đào ngâm kiểu “lười”, kiểu đơn giản nhất trong các kiểu,…",
                        PostContent = "Từ syrup đào ngâm kiểu này, mình tự nuôi thêm kombucha và sau khi thu hoạch nước kombucha thì “nuôi” thêm 1 ngày phần nước kombucha không có con scoby đó với đào ngâm này cho ra kombucha đào ngon tuyệt vời!\r\nTỉ lệ nước kombucha: nước cốt đào ngâm là 3:1 hoặc 4:1 tuỳ khẩu vị.\r\nCách làm đào ngâm kiểu lừoi:\r\nNguyên liệu:\r\n5kg đào\r\n2-3kg đường nâu\r\n1 thìa nhỏ muối\r\n4-5 hạt đinh hương hoặc 1 mảnh quế (không có thì thôi)\r\n2 thìa to rượu trắng.\r\nCách làm:\r\n1. Đào rửa sạch để ráo. Gọt bỏ vỏ hoặc không tuỳ độ lười. Rồi bổ miếng vừa ăn.\r\n2. Cho hết đào vào một hộp/hũ to đã tráng nước sôi để ráo nguội.\r\n3. Cho đường phủ lên trên, rắc muối, đinh hương.\r\n4. Đậy nắp lắc cho đường rơi dần xuống.\r\n5. Sang ngày hôm sau đào đã tiết nước thì đổ rượu vào. khi nào đào tiết đủ nước ngập đào thì bảo quản tủ lạnh ăn dần.\r\nCách làm cực dễ mà thành phẩm ngon đã đời.\r\nChẳng gì tuyệt bằng một ly chua chua ngọt ngọt thơm nức vị đào, vị trà kombucha mát lạnh lịm tim, bốn mùa đèu ngon!\r\nMọi người làm thử nhé!",
                        Published = true,
                        UrlSlug = "Post11",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post11.jpg"
                    },
                    new Post()
                    {
                        Id = 12,
                        Title = "CÁCH LÀM TRÀ SỮA BÍ ĐAO THANH NHIỆT NGON ĐỈNH KAO DỰ SẼ HOT TREND HÈ NÀY",
                        ShortDescription = "CÁCH LÀM TRÀ SỮA BÍ ĐAO THANH NHIỆT NGON ĐỈNH KAO DỰ SẼ HOT TREND HÈ NÀY /Topping trân châu 3Q đường đen + thạch đen sẽ là the best combo nhé/ Mê trà sữa, cần một thức uống mát…",
                        PostContent = "Nguyên liệu:\r\nA. Phần trà bí đao:\r\n⁃ 1kg bí đao / hoặc bí xanh (*)\r\n⁃ 2 quả la hán\r\n⁃ 20 quả táo tàu\r\n(*) Nhiều người coi bí đao và bí xanh là một. Có thể do bí xanh khi già đi trông khá giống bí đao. Tuy nhiên với mình, mình đã từng ăn rất nhiều loại bí xanh, bí đao khác nhau. Bí xanh thịt, ruột và vỏ đều mềm, mùi hăng hơn, vị chua hơn, vỏ xanh khi già dần có phấn. Còn bí đao vỏ rất cứng, lớp phấn dày từ lúc quả non, thịt quả chắc nịch, ruột giòn, khi nấu không có vị chua nên “trà bí đao” có mùi vị đặc trưng là vậy.\r\nTuy nhiên nấu trà bí xanh cũng rất ngon. Trong hình là hôm nhà mình được tặng quả bí xanh hữu cơ nên mình làm luôn, cũng ngon, không chua vì mình dùng chế độ nấu chậm nhiệt độ thấp của nồi áp suất đa năng nó chiết suất chất ra rất kiệt, nhiệt độ chuẩn, không bị quá cao mất dinh dưỡng và bị chua nhá!\r\nB. Phần pha trà sữa:\r\n⁃ Sữa đặc có đường/ hoặc sữa tươi theo khẩu vị\r\n⁃ Trân châu 3Q đường đen (trân châu giòn, rất ngon, mình mua gói sẵn 40K ăn bét nhè ở MAY Shop – Đồ Làm Bánh ship tận nơi)\r\n⁃ Thạch đen Cao Bằng (mình mua sẵn thạch An trong siêu thị. Cực hợp với vị trà sữa bí đao)\r\nCách làm từng bước trong hình nhá các bạn ơi!\r\nLàm thành công nhớ khoe Yêu Bếp nhá!\r\nThơm cực thơm, mát cực mát, vẫn có độ ngậy béo của trà sữa mà lại thanh mát giải nhiệt của trà bí đao! Ta nói nó đã khát mùa hè!\r\nNạo vỏ bí nào! Nhớ rửa thật sạch bí trước khi nạo.\r\nGiữ lại vỏ bí, cho vào nồi.\r\nNạo sợi thịt bí. Vì đây là bí xanh, thịt mềm, nếu ninh cùng dễ bị chua nước & đục do bị nát nên sẽ nạo sợi để riêng nhé!\r\nPhần ruột và hạt bí dùng luôn nha! Cắt khúc cho vào nồi cùng vỏ bí\r\nLa hán quả. Đập vỡ vỏ. Chọn quà chín già, cứng vỏ và ruột đen sẽ thơm ngọt và đậm màu nước hơn",
                        Published = true,
                        UrlSlug = "Post12",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post12.jpg"
                    },
                    new Post()
                    {
                        Id = 13,
                        Title = "[MÓN NGON NGÀY TẾT] THỬ TÀI KHÉO TAY LÀM DƯA CHUỘT LỐC XOÁY GIẢI NGẤY CỖ TẾT",
                        ShortDescription = "[MÓN NGON NGÀY TẾT] THỬ TÀI KHÉO TAY LÀM DƯA CHUỘT LỐC XOÁY GIẢI NGẤY CỖ TẾT Tết này, đừng bỏ qua món Dưa Chuột Lốc Xoáy này nhé! Một món ăn cực hay ho, giải ngấy bánh chưng thịt…",
                        PostContent = "Tết nhất nhà nào cũng có bánh chưng, giò xào, hay thịt đông trong mâm cỗ. Chỉ cần một đĩa Dưa chuột này thôi cũng xin là cuốn ngay cơn “ngấy” tan nhanh như lốc xoáy.\r\n\U0001f952 CHUẨN BỊ:\r\n– 2 Quả dưa chuột Nhật\r\n– 1 Tbsp muối tinh\r\n– Nước lọc\r\n🌪 GIA VỊ\r\n– 1 tsp muối\r\n– 2 Tbsp đường\r\n– 2 Tbsp ớt bột\r\n– 3 Tbsp dầu mè\r\n– 3 lòng đỏ trứng gà tươi\r\n– Mè rang (tùy thích)\r\nTạo hình dưa lốc xoáy không hề cần kĩ thuật hay cách cắt tỉa cầu kỳ.\r\nDưa chuột là loại quả giòn thơm, có vị ngọt thanh và ăn rất mát.\r\nTrong mâm cơm hàng ngày, các món cuốn hay đặc biệt là cỗ Tết luôn có dưa chuột ăn kèm để giải ngấy rất hiệu quả.\r\nThay vì thái khoanh mỏng như mọi lần, hãy thử tài khéo tay tạo hình lốc xoáy như mình nhé!\r\nBên cạnh dưa chuột thanh mát thì sẽ cần thêm một xíu gia vị để tạo vị mặn ngon, ngậy thơm như muối, đường, bột ớt và dầu mè.\r\nBên cạnh “giao diện” lốc xoáy cực choáyy thì món ăn kèm này còn gây ấn tượng bởi mùi thơm nức của dầu mè, vị ngậy xốt trứng gà mà ai cũng mê mẩn",
                        Published = true,
                        UrlSlug = "Post13",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post13.jpg"
                    },
                    new Post()
                    {
                        Id = 14,
                        Title = "ĐỔI MÓN NGÀY HÈ VỚI XỐT TRÁI BƠ GUACAMOLE PHIÊN BẢN VIỆT HÓA CỰC LẠ MIỆNG",
                        ShortDescription = "ĐỔI MÓN NGÀY HÈ VỚI XỐT TRÁI BƠ GUACAMOLE PHIÊN BẢN VIỆT HÓA CỰC LẠ MIỆNG Ai bảo món “ăn nhanh” là không healthy ra đây gặp guacamole (đọc là guaa-ka-mô-li)! Guacamole – món xốt ăn kèm làm từ quả…",
                        PostContent = "Ai bảo món “ăn nhanh” là không healthy ra đây gặp guacamole (đọc là guaa-ka-mô-li)!\r\nGuacamole – món xốt ăn kèm làm từ quả bơ đến từ đất nước Mexico xa xôi nay đã xuất hiện tại bếp bà Sheep trong phiên bản “Việt hóa” ngon tuyệt.\r\nĐầu tiên, tortilla chips (vỏ bánh bột ngô chiên giòn) được thay thế bằng bánh tráng mè tôm đặc sản Tây Ninh nướng bằng NCKD, giòn rôm rốp không hề bị sũng dầu. Tiếp theo, vẫn là những nguyên liệu truyền thống, nào bơ, cà chua, rau mùi rồi tỏi, hành tím nay được bổ sung một loại gia vị “thần kì”, tạo ra một cú “plot twist” đậm vị Việt trong tổng thể món ăn.\r\nBạn thử đoán xem gia vị bí mật ấy là gì nhé?\r\nMón này không chỉ “ăn nhanh” mà làm cũng nhanh nữa. Với sự giúp đỡ của bộ đôi trợ thủ đến từ Philips – máy xanh sinh tố cùng NCKD XXL, mình chỉ cần có 10 phút là đã hoàn thành rùi á.\r\nNhân dịp nghỉ lễ này, thử đổi món khai vị cho cả nhà với guacamole phiên bản Việt nhé! Đảm bảo từ người lớn cho đến trẻ con trong nhà bạn cũng đều sẽ mê mẩn cho mà xem.",
                        Published = true,
                        UrlSlug = "Post14",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post14.jpg"
                    },
                    new Post()
                    {
                        Id = 15,
                        Title = "BÍ KÍP “LÊN ĐỒ” CHO TRỨNG MUỐI CÁCH LÀM NGỌC RỒNG LỤC SẮC",
                        ShortDescription = "Nhìn vào ẩm thực thế giới, có lẽ trứng là một trong những nguyên liệu cơ bản và quan trọng nhất. Ở bất cứ vai trò nào, dù là một thành phần trong công thức hay đứng riêng như một…",
                        PostContent = "Nhìn vào ẩm thực thế giới, có lẽ trứng là một trong những nguyên liệu cơ bản và quan trọng nhất. Ở bất cứ vai trò nào, dù là một thành phần trong công thức hay đứng riêng như một món độc lập, trứng cũng tròn vai. Người ta dùng trứng làm bánh, làm mì, rán trứng, hấp trứng, xào trứng, rụng…ơ không, ý là rụng rời vì sự thiên biến vạn hoá của trứng! Thế nên dễ hiểu vì sao khi người ta “muối cả thế giới”, người ta không thể bỏ qua trứng được.\r\n\r\nỞ kỳ trước của chuyên mục “Muối cả thế giới” của Esheep Kitchen, chúng mình đã hướng dẫn mọi người cách làm trứng “khoả thân” ở đây\r\nGió mùa ùa về, gõ cửa mỗi nhà nhắc người ta mặc cho ấm vào thì trứng muối của chúng mình cũng sẽ lên đồ, thật lồng lộn và sang chảnh để hoá thân thành ngọc rồng lục sắc.\r\nNgọc rồng lục sắc sinh ra để dành cho mùa đông. Tưởng tượng nhé, trời lành lạnh mà được ủ ấm lòng bàn tay với một thứ tròn trịa ấm sực và thơm nức thế này thì chả ai cần người yêu đâu ý! Chưa kể, mỗi viên ngọc rồng lục sắc cứ như là một chiếc rương bí mật chờ ta khám phá. Nhẹ nhàng tách từng miếng vỏ trứng, phần châu báu, ngọc ngà bên trong từ từ lộ ra với gạo đồ căng mẩy ỏng ả, đậu Hà Lan tròn lẳn như những viên ngọc trai, đâu đó lấp ló một chút lạp xưởng đỏ lấp lánh như ruby vui mắt. Và rồi, khi chạm dần xuống đáy rương, người ta sẽ khẽ reo lên khi phát hiện ra viên ngọc quý, đẹp nhất và lấp lánh nhất – phần lòng đỏ trứng muối. Với vị mặn bùi, béo ngậy cùng vẻ ngoài vàng óng, bóng bẩy như một mặt trời tí hon, phần lòng đỏ trứng muối không chỉ là một điểm nhấn về hương vị mà còn là nét chấm phá cho toàn bộ món ăn thêm phần rực rỡ.\r\n\r\n \r\n\r\nĐây là một món ăn mang âm hưởng của ẩm thực Hoa, vốn được làm với gạo nếp, nhưng tiện mùa gạo đồ đang ngon căng mẩy, chúng mình đã mày mò làm thử với gạo đồ và thu được một mẻ ngọc rồng thơm ngon xuất sắc.\r\nNguyên liệu \r\nThịt ba chỉ: 200g\r\n\r\nGạo nếp đồ: 200g\r\n\r\nTrứng vịt muối sống: 20 quả\r\n\r\nNấm hương khô: 5 cái (ngâm nước lạnh cho nở trước khi làm)\r\n\r\nLạp xưởng: 1 cái\r\n\r\nĐậu Hà Lan: 3 thìa to\r\n\r\nRượu Thiệu Hưng: 1 thìa to\r\n\r\nXì dầu: 1 thìa to\r\n\r\nHắc xì dầu: 1 thìa to\r\n\r\n¼ thìa nhỏ muối\r\n\r\n½ thìa nhỏ đường\r\n\r\nNhư mọi người thấy, gạo đồ trong hình trông rất khác với gạo nếp hay gạo tẻ thường, từ hình dáng cho đến màu sắc. Thế gạo đồ có phải là hạt gạo của một giống lúa mới lạ không?",
                        Published = true,
                        UrlSlug = "Post15",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post15.jpg"
                    },
                    new Post()
                    {
                        Id = 16,
                        Title = "THỬ THÁCH VETULA NGÀY TẾT NẤU MÂM CƠM 7 MÓN SIÊU NGON CHỈ TRONG MỘT LẦN NẤU 45 PHÚT!!!",
                        ShortDescription = "THỬ THÁCH VETULA NGÀY TẾT NẤU MÂM CƠM 7 MÓN SIÊU NGON CHỈ TRONG MỘT LẦN NẤU 45 PHÚT!!! Tết hết thật rồi!!! Và thế là công cuộc giải ngán, tiêu thụ đồ ăn thừa ngày Tết chính thức bắt…",
                        PostContent = "Lưu về và thử ngay với mình nhé!\r\nNguyên liệu:\r\n– 400g ba chỉ nguyên miếng\r\n– 3 quả trứng vịt (trứng sống chưa luộc, rửa sạch vỏ)\r\n– 2 củ khoai tây\r\n– 1 quả cà tím dài\r\n– 3 quả ớt chuông\r\n– 2 cây nấm đùi gà to\r\n– 1 bìa đậu\r\n– 1 củ tỏi bóc sẵn\r\n– 3 củ hành khô bóc sẵn\r\n– 1 Tbsp tiêu sọ\r\n– 1 lít Nước lọc\r\nXốt ngũ vị:\r\n– 150ml xì dầu càng cua\r\n– 3 Tbsp đường nâu\r\n– 3 Tbsp dấm\r\n– 3 Tbsp dầu hào\r\n– 3 Tbsp tương ớt Chinsu\r\n– 2 Tbsp dầu điều\r\n– 2 Tbsp dầu mè\r\nTrang trí món:\r\n– Vừng trắng rang vàng\r\n– Ớt tươi thái lát\r\n– Hành lá thái nhỏ\r\n– Đầu hành chẻ nhỏ\r\n– Rau mùi\r\nCách làm rất dễ, bạn xem đến cuối phần hình ảnh nhé, hoặc xem ngay video\r\nmới nhất trên kênh Youtube Esheep Kitchen ",
                        Published = true,
                        UrlSlug = "Post16",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post16.jpg"
                    } ,
                    new Post()
                    {
                        Id = 17,
                        Title = "#VuiTếttraođi [MÓN NGON ĐÓN TẾT] PHÁT HIỆN CÁCH LÀM CƠM GÀ HẢI NAM PHIÊN BẢN CỰC DỄ",
                        ShortDescription = "#VuiTếttraođi [MÓN NGON ĐÓN TẾT] PHÁT HIỆN CÁCH LÀM CƠM GÀ HẢI NAM PHIÊN BẢN CỰC DỄ /Mẹo hấp thịt gà dai giòn, mềm mọng siêu ngon/ Bạn có bao giờ thắc mắc chỉ một đĩa cơm trắng với thịt…",
                        PostContent = "Đây cũng là một gợi ý đổi món cho mấy ngày Tết, bạn lưu về và làm thử ngay với mình nhé!\r\nNguyên liệu thì đơn giản:\r\n🐥 Phần cơm gà:\r\n4 Tbsp dầu gừng (xem cách làm chi tiết trong hình)\r\n500g gạo hạt dài\r\n1 Tbsp xì dầu\r\nNước vừa đủ nấu cơm\r\n800g gà ta (gồm đùi tỏi và lườn gà)\r\n6-8 tép tỏi\r\n6 lát gừng\r\n5-6 lá nếp\r\n1 nắm hành lá\r\n\U0001f924 Phần nước xốt:\r\nXốt gừng – trắng:\r\n2 Tbsp gừng xay\r\n1 Tbsp tỏi xay\r\n1 Tbsp đầu hành trắng xay\r\n1 Tbsp nước cốt gà\r\n1 Tbsp dầu gừng\r\nVài tép tỏi hấp chín\r\nXốt ớt – đỏ:\r\n1 quả ớt sừng to\r\n2 quả ớt hiểm\r\n1 Tbsp gừng xay\r\n1 Tbsp tỏi xay\r\n2 Tbsp nước quất\r\n2 Tbsp đường\r\n1 tsp muối\r\n1 Tbsp dầu gừng\r\n1 Tbsp nước cốt gà\r\nVài tép tỏi hấp chín\r\nXốt tương ngọt – đen\r\n2 Tbsp xì dầu\r\n1 Tbsp dầu mè (tùy khẩu vị)\r\n1 Tbsp mật mía\r\nMọi hình ảnh và nội dung bài tham dự Thử Thách “Vui Tết Trao-Đi” đều thuộc bản quyền của nhóm Yêu Bếp (Esheep Kitchen Family). Các đơn vị truyền thông/ báo chí muốn chia sẻ thông tin vui lòng liên hệ fanpage Admin Yêu Bếp để được hướng dẫn.\r\nCùng từ những nguyên liệu đơn giản như gạo, thịt gà, các gia vị như tỏi, gửng, ớt, món cơm gà ở mỗi vùng miền, đất nước lại có vị ngon khác nhau. Nếu như cơm gà Hội An dẻo thơm mà vẫn khô tơi, ăn kèm với gỏi và lòng gà xào nóng hổi thì và thì cơm gà Hải Nam lại thơm dẻo mùi dầu gừng, ăn kèm với bộ ba nước xốt rất cuốn.\r\nHôm nay đổi bữa, ăn thử cơm gà Hải Nam xem sao nhé!",
                        Published = true,
                        UrlSlug = "Post17",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post17.jpg"
                    },
                    new Post()
                    {
                        Id = 18,
                        Title = "CÁCH LÀM GIẢ CẦY MIỀN BẮC THƠM MỀM ĐẬM VỊ /Nấu giả cầy A-Z nhanh – gọn – dễ chỉ cần nồi áp suất/",
                        ShortDescription = "CÁCH LÀM GIẢ CẦY MIỀN BẮC THƠM MỀM ĐẬM VỊ /Nấu giả cầy A-Z nhanh – gọn – dễ chỉ cần nồi áp suất/ Lạ lùng thật sự, món thì “GIẢ” mà hương vị lại ngon “THẬT”. Nấu nhanh thật…",
                        PostContent = "Với công thức của mình, cách nấu giả cầy được giản tiện hơn bao giờ hết, chỉ cần đúng một chiếc nồi áp suất đa năng có thể “cân” mọi công đoạn, từ xào – om – ninh nhừ tất tật chỉ trong vài nút bấm, hô biến 1 niêu giả cầy nóng hổi, thơm nức đậm đà mà bếp núc sạch tinh, gọn gàng mới hay chứ!\r\nNGUYÊN LIỆU:\r\n– 2 cái móng giò\r\n– 500g thịt chân giò\r\n– 500g măng củ tươi\r\n– 100gr riềng xay\r\n– 1 mẩu nghệ nhỏ\r\n– 3 cây sả (băm nhuyễn)\r\n– 100ml mẻ (lọc sạch)\r\n– 2 Tbsp muối\r\n– 2 Tbsp đường\r\n– 3 Tbsp mắm tôm\r\n– 1,2 lít nước\r\n– 1 Tbsp dầu ăn\r\nCách làm mình sẽ chia sẻ trong từng ảnh nha.\r\nVà đừng quên ghé kênh Tích Tốc của chúng mình để học lỏm các mẹo nấu nướng với nồi áp suất và gặp “Ông Thương” – idol nấu ăn mới nổi của Esheep Kitchen nha! link đây link đây https://vt.tiktok.com/ZS86QxVer/\r\nTrời lạnh mà có niêu giả cầy nóng sốt, gắp miếng chân giò mềm dẻo, chấm miếng bún xu đẫm nước om rồi thêm vài chén cay cay thì hết bài!!",
                        Published = true,
                        UrlSlug = "Post18",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post18.jpg"
                    },
                    new Post()
                    {
                        Id = 19,
                        Title = "PHÁT HIỆN CÁCH LÀM GỎI NIỄNG NƯỚNG TAI HEO GIÒN NGON CỰC LẠ MIỆNG /Mẹo thưởng thức đặc sản ĐÙI MỸ NHÂN trong truyền thuyết/",
                        ShortDescription = "PHÁT HIỆN CÁCH LÀM GỎI NIỄNG NƯỚNG TAI HEO GIÒN NGON CỰC LẠ MIỆNG /Mẹo thưởng thức đặc sản ĐÙI MỸ NHÂN trong truyền thuyết/ Một lần đi du lịch Đài Loan, mình háo hức được thử món ĐÙI MỸ…",
                        PostContent = "Mau mau làm thử thức quà thời trân này nhá, không kẻo hết mùa niễng đến nơi rồii các bạn ơii ❤\r\nNguyên liệu cực dễ:\r\n2 bó củ niễng\r\n1 cái tai heo\r\n1 củ cà rốt nhỏ\r\n1 quả dưa chuột\r\n1 củ hành tây tím\r\nRau răm, rau mùi\r\nLạc, vừng rang thơm\r\nXốt trộn gỏi:\r\n2 tép tỏi to (băm nhỏ)\r\n1-2 quả ớt cay (băm nhỏ)\r\n2 Tbsp nước mắm\r\n2 Tbsp nước cốt chanh\r\n2 Tbsp đường kính\r\n2 Tbsp nước lọc\r\nSơ chế hành tím:\r\nNước đá lạnh\r\n1 Tbsp nước cốt chanh\r\n1 Tbsp đường\r\n1 Tbsp giấm\r\nCách làm siêu cấp dễ, ai cũng có thể làm, bạn xem trong từng ảnh nhé. Ngoài ra, dành riêng cho anh em đang thèm món này thì xem ngay video siêu ngon mắt ngon miệng:",
                        Published = true,
                        UrlSlug = "Post19",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post19.jpg"
                    },
                    new Post()
                    {
                        Id = 20,
                        Title = "CÁCH LÀM XỐT CHẤM ME ĐẬU PHỘNG THƠM BÙI",
                        ShortDescription = "CÁCH LÀM XỐT CHẤM ME ĐẬU PHỘNG THƠM BÙI /Công thức xốt bất bại của mẹ, chấm cả Thế giới/ Nhiều bạn hỏi công thức làm xốt chấm quá nên nay trời lạnh rồi, mình mạnh dạn giới thiệu ngay…",
                        PostContent = "Tương truyền, đây là loại xốt quyền năng xua tan đi cái sự ngấy của các loại thịt thà, lại là “chìa khóa” để thổi bùng hương vị cho món cuốn, món nướng, thậm chí chấm hoa quả thôi cũng đỉnh.\r\nNói chung là chấm cả Thế giới, chắc chỉ có mỗi chấm công là bạn phải tự đến đúng giờ thôi =))))\r\nNguyên liệu thì đây, làm luôn và ngay:\r\n– 50g cốt me\r\n– 4 Tbsp đường vàng\r\n– 4 Tbsp nước mắm\r\n– 2 Tbsp tép/ tôm khô\r\n– 1 cup nước\r\n– 2 củ hành tím băm\r\n– 1 củ hành tím xắt lát\r\n– 1 Tbsp ớt sừng băm\r\n– Lạc rang giã vụn (ít nhiều tùy thích)\r\nCách làm vẫn cứ là siêu đơn giản, giả vờ bí mật chứ mình hướng dẫn chi tiết trong từng ảnh.\r\nCòn ai là fan của Fast&Furious muốn học cách nấu xốt chấm nhanh siêu tốc chưa tới 1 phút thì ghé ngay kênh Tóp Tóp của mình nhé https://vt.tiktok.com/ZSRpE67nH/\r\nBạn ơi đừng ngh.i.ệ.n nứa!\r\nNhà mình còn gì đâu\r\nCòn tí xốt màu nâu\r\nLà xốt me đậu phộng =))",
                        Published = true,
                        UrlSlug = "Post20",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post20.jpg"
                    },
                    new Post()
                    {
                        Id = 21,
                        Title = "CÀ MUỐI XỔI NGÀY BÃO",
                        ShortDescription = "[Cà muối xổi ngày bão] Là vại mắm cà lá chanh trắng giòn bôm bốp này đây. Những ngày bão rớt, nhà có vại cà này, thêm nồi cá kho thịt kho, thêm đĩa rau luộc, vài hạt lạc rang…",
                        PostContent = "Mắm cà này có thể ăn xổi ngay sau khi muối, và bắt đầu ăn ngon – có độ chua sau tầm 2-3 ngày. Khi chua đủ độ, tiếp tục quản ngăn mát tủ lạnh có thể trữ được một vài tháng mà không bị chua thêm.\r\nNguyên liệu rất đơn giản, bạn làm thử nhé:\r\n500g cà pháo trắng\r\n_ 1 quả chanh\r\n_ 1 muỗng canh muối hạt\r\nGia vị ướp cà:\r\n_ 50g tỏi\r\n_ 20g gừng\r\n_ 20g riềng\r\n_ 3 quả ớt sừng\r\n_ 100g đường vàng\r\nMắm ngâm cà:\r\n_ 3 thìa tương ớt lên men\r\n_ 100ml nước quất\r\n_ 100ml nước mắm\r\n_ 100ml dấm\r\nRắc khi ăn:\r\n– 1 nắm lá chanh\r\nA. Sơ chế:\r\n– Cà cắt bỏ cuống, bổ miếng, ngâm với nước muối hạt và chanh 30p, sau đó rửa sạch với nước 3_4 lần cho cà trắng.\r\nB. Trong lúc đó chuẩn bị phần gia vị ướp & mắm ngâm:\r\n– Cho gừng riềng tỏi,ớt cho vào máy xay nhuyễn với đường.\r\n– Cà rửa sạch cho ráo nước, trộn cùng gia vị & mắm ngâm.\r\n– Ăn ngay hoặc sau 2-3 ngày chua đủ độ, tiếp tục trữ ngăn mát tủ lạnh ăn dần.",
                        Published = true,
                        UrlSlug = "Post21",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post21.jpg"
                    },
                    new Post()
                    {
                        Id = 22,
                        Title = "CÁCH LÀM HẠT DẺ NƯỚNG NGÀO MẬT ONG THƠM BÙI /Mẹo nướng hạt dẻ siêu nhanh, róc vỏ dễ bóc bằng NCKD/.",
                        ShortDescription = "CÁCH LÀM HẠT DẺ NƯỚNG NGÀO MẬT ONG THƠM BÙI /Mẹo nướng hạt dẻ siêu nhanh, róc vỏ dễ bóc bằng NCKD/. Sau 7749 pha vấp ngã thì đây chính là cách nướng hạt dẻ đơn giản nhất mà ai…",
                        PostContent = "Sau 7749 pha vấp ngã thì đây chính là cách nướng hạt dẻ đơn giản nhất mà ai cũng nên biết!\r\nKhông cầu kì, không bí thuật, chỉ cần có NCKD là xong hết.\r\nCách làm siêu đơn giản mà kết quả thì quá mĩ mãn.\r\nHạt dẻ vàng ruộm, bóc nhẹ cái là róc hết vỏ. Hương vị bùi thơm mà không bị khô sượng, chẳng lo nổ vỏ bùm bụp bắn bẩn ra bếp.\r\nHạt dẻ có thể chế biến được rất nhiều món như hầm canh, om với thịt hay rang hoặc nướng ăn liền đều rất ngon.\r\nMùa đông mình sẽ ngào hạt dẻ với mật ong, vừa ngọt thơm lại có lợi cho sức khỏe bởi đây đều là nguyên liệu, hạt rất giàu dinh dưỡng và có tác dụng chống nhiễm khuẩn (là một trong những nguyên nhân gây cảm cúm, viêm họng..)\r\nNguyên liệu cực dễ kiếm:\r\n– 1 kg hạt dẻ tươi\r\n– 1/2 Tbsp muối\r\n– 1 lít nước\r\n– 70ml mật ong (hoặc lượng tùy thích).\r\n– Vừng rang thơm\r\nCách làm mình sẽ hướng dẫn trong từng ảnh, kèm mẹo nướng hạt dẻ róc vỏ cực đỉnh luôn.\r\nBạn nào muốn nghe tiếng hạt dẻ nướng vỏ giòn rôm rốp, nhân hạt vàng ruộm dẻo bùi, óng ánh màu mật ong thì xem ngay trên kênh TikTok Yêu Bếp nha https://vt.tiktok.com/ZSRvFhsNV/\r\nMùa đông mà có vốc hạt rẻ rang nóng hổi, thơm lừng thì còn gì bằng.",
                        Published = true,
                        UrlSlug = "Post22",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post22.jpg"
                    },
                    new Post()
                    {
                        Id = 23,
                        Title = "VALENTINE HEART-MADE / CÁCH BỎ BÙA YÊU BẰNG THẠCH RUBY LÓNG LÁNH NÚNG NÍNH",
                        ShortDescription = "VALENTINE HEART-MADE CÁCH BỎ BÙA YÊU BẰNG THẠCH RUBY LÓNG LÁNH NÚNH NÍNH Thạch trái tim ruby lóng lánh tuyệt xinh mà lại thanh mát siêu ngon này được làm trong tích tắc, ai cũng làm được. Mà biết đâu…",
                        PostContent = "VALENTINE HEART-MADE\r\nCÁCH BỎ BÙA YÊU BẰNG THẠCH RUBY LÓNG LÁNH NÚNH NÍNH\r\nThạch trái tim ruby lóng lánh tuyệt xinh mà lại thanh mát siêu ngon này được làm trong tích tắc, ai cũng làm được. Mà biết đâu lại hút hơn cả sô cô la ấy chứ!\r\nBạn có muốn thử không?\r\nĐăch biệt, các bạn nhóc sẽ siêu thích khi có thể tự làm để tặng bố mẹ hoặc cùng làm với bố mẹ. Bạn thử nhé!\r\nCác làm mình đã hướng dẫn tại đây! Cùng xem nhá!\r\nChúc các bạn một mùa Valentine thật lung linh & ngọt ngào nhá!\r\nhttps://vt.tiktok.com/ZSenXCsqu/\r\n—\r\nHãy dành một lời nhắn ngọt ngào tới người bạn yêu quý tại đây, và tag họ nhá!",
                        Published = true,
                        UrlSlug = "Post23",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post23.jpg"
                    },
                    new Post()
                    {
                        Id = 24,
                        Title = "CÁCH LÀM CHÈ HOÀI SƠN TÁO ĐỎ ĂN TẾT TIÊU NGẤY, DƯỠNG NHAN",
                        ShortDescription = "30 Tết, ngày cuối cùng của năm, làm một món thật ngon thắp hương ông bà Tổ Tiên, để đón một năm mới rộn ràng niềm vui nhé! Năm nay, thật may mắn khi mình tìm lại được một món…",
                        PostContent = "Bấy nay bặt tăm không thấy, năm nay những ngày giáp Tết, mình tình cờ tìm tìm thấy nguyên cả một thửa ruộng trồng hoài sơn mới dỡ, người nông dân còn đang xếp lên hàng chồng củ tươi còn rỉ nhựa, thơm nồng mùi đất mới, thật thích không tả được. Rồi mình nhớ lại món chè hoài sơn táo đỏ ngày Tết ngày xưa. Thật không ngờ có dịp làm lại món này cho Tết nay. Mình nhớ các bà nấu món này ngon lắm, không đánh thêm chút bột nào mà chè vẫn sánh vì tự củ tiết ra chất dẻo sóng sánh. Nước chè thanh mát từ đường phèn, nhãn nhục. Đặc biệt, mùi chè rất thơm vì mùi hoài sơn bở tung quyện với thứ “gia vị” bí mật mà bao năm sau mình vẫn lưu luyết mãi bát chè ấy, đó chính là một nhúm trần bì – vỏ quýt hôi treo khô, được thái chỉ nhỏ tý thả vào nồi chè. Chè hoài sơn thường được nấu cùng táo đỏ – loại táo tàu khô tự nhiên màu còn đỏ như son, rất bổ dưỡng và ngon miệng. Ngoài ra còn nhân hạt bí trắng bùi bùi sần sật. Năm nay, mình quyết dành thời gian rảnh rỗi những ngày cuối để “phục dựng” lại mâm chè Tết như năm xưa. Có điều tiếc thay mình không còn trần bì, và không có nhân hạt dưa nên thay bằng hạt thông, không ngờ hạt thông cũng ngon tuyệt vời và rất hợp với món này. Về củ hoài sơn tươi, nay đang mùa, các bạn có thể tìm mua ở các chợ, hỏi hàng rau, hàng lá nhé. Hoặc nếu không kịp làm ăn Tết, thì ra Giêng ngày rộng tháng dài, hãy làm thử ăn chơi… Món này vừa ngon vừa bổ, đặc biệt hợp với trẻ con người già, vì bác mình bảo chè này ăn để tăng cường sinh lực và sức đề kháng chống bệnh tật lúc chuyển mùa ẩm ướt. Các nguyên liệu còn lại bạn hỏi mua ở hàng thuốc Bắc nhé. Món chè này không hề khó, nhưng cần cầu kì tỉ mỉ để ngon hoàn thiện từng loại nguyên liệu, đúng kiểu cách Hà Nội xưa, nấu chè cũng không vội được đâu <3 Cùng làm thôi!\r\n\r\nNguyên liệu:\r\n\r\n1 củ hoài sơn (khoai mài) khoảng 1kg.\r\n\r\n100g táo đỏ 50g nhãn nhục (long nhãn khô)\r\n\r\n50g hạt thông/ nhân hạt dưa đã tách vỏ\r\n\r\n1 thìa nhỏ trần bì (mình không có nên thay bằng vỏ cam vàng bào nhuyễn)\r\n\r\n1 nhúm nhỏ muối\r\n\r\n250g -400g đường phèn tuỳ khẩu vị\r\n\r\ntổng 3,5 lít nước để nấu chè\r\n\r\nCách làm:\r\n\r\n⁃ Táo đỏ rửa sạch, cho vào một bát to, đổ ngập nhiều nước ngâm khoảng 30 phút.",
                        Published = true,
                        UrlSlug = "Post24",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post24.jpg"
                    },
                    new Post()
                    {
                        Id = 25,
                        Title = "PHỞ GÀ GIA TRUYỀN “BÀ ANH” NGỌT THƠM KHÔNG CẦN MÌ CHÍNH",
                        ShortDescription = "PHỞ GÀ GIA TRUYỀN “BÀ ANH” NGỌT THƠM KHÔNG CẦN MÌ CHÍNH Dù là bế mạc Festival Âm lịch nhưng vẫn đang kì nghỉ cuối tuần 😃 Thôi nào, thú nhận đi, nhà bạn vẫn còn thịt gà đúng không…",
                        PostContent = "Thật ra, phở gà là một món dù nấu cầu kỳ hay đơn giản cũng đều có thể cho ra hương vị ấn tượng, nên để bàn thế nào là “chuẩn” sẽ rất khó để không gây tranh cãi.\r\nNhưng không vì thế mà lại… lười nấu phở được, mình sẽ hướng dẫn các bạn cách nấu một nồi phở gà đặc biệt, kèm một số mẹo vặt đơn giản tại nhà để có một hương vị nước dùng ngọt thanh không kém gì phở tiệm nổi tiếng nhé 😃\r\nĐây chắc chắn sẽ là một món hết veo trong những ngày cuối tuần này đó!\r\n🐔 Nguyên liệu:\r\n– 1 con gà ta già (~3kg)\r\n– 2 bộ xương lưng gà\r\n– 2 bộ tràng trứng non\r\n– 1 bộ lòng gà\r\n– 100g tim gà\r\n\U0001f9c2 Gia vị luộc gà:\r\n– 1 Tbsp muối\r\n– 1 tsp đường phèn\r\n– 1 mẩu gừng thái lát\r\n– 3 củ hành khô\r\n🍲 Nước dùng phở gà:\r\n– 10 con sá sùng nướng\r\n– 2 củ hành tây nướng thơm\r\n– 100g hành khô nướng nguyên vỏ\r\n– 100g gừng nướng\r\n– 1 nắm to rễ hành, rễ mùi\r\n– 5-7 lá chanh tươi\r\n– 1 Tbsp tiêu sọ trắng\r\n– 1 Tsp hạt mùi\r\n– 1 bông hoa hồi, 1 thanh quế nhỏ rang thơm\r\n– ¼ cup nước mắm ngon\r\n– Muối tinh\r\nCách làm mình đã ghi chi tiết trong từng ảnh, bạn đừng bỏ qua nhé!\r\nPhở gà là một nét đặc trưng của ẩm thực Hà Nội, và còn gì vui hơn khi bạn đã có thể nấu được những bát phở ngon tròn vị ngay tại nhà.\r\nĐừng quên thả tim cho kênh Tích Tốc của chúng mình và theo dõi phiên bản phở gà bà Anh, được hướng dẫn bằng vi-đê-ô vừa ngon mắt, vừa đã tai nhé!",
                        Published = true,
                        UrlSlug = "Post25",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post25.jpg"
                    },
                    new Post()
                    {
                        Id = 26,
                        Title = "CÁCH LÀM LỢN NƯỚNG LÁ LỐT NGON CHẤN ĐỘNG",
                        ShortDescription = "CÁCH LÀM LỢN NƯỚNG LÁ LỐT NGON CHẤN ĐỘNG /Bí kíp nấu xốt me đậu phộng chấm cả thế giới/ Mai thứ 7 rồi bà con ơi!! Làm ngay một mẹt lợn nướng lá lốt nóng hổi cuốn rau sống…",
                        PostContent = "Nấu nướng cực đơn giản với mẹo nướng bằng lò nướng/ NCKD của mình mà thịt lợn vẫn mềm mọng không khô, không phải kì cạch quạt than làm gì cho nó cay xè mắt ra. Đôi mắt ấy… hãy dành để đọc hết công thức này của mình và share về nhé =))))\r\nNguyên liệu:\r\n– 500g thịt lợn xay\r\n– 2 Tbsp hành sả băm\r\n– 1 Tbsp nước mắm\r\n– 1 Tbsp dầu hào\r\n– 1 Tbsp dầu ăn\r\n– 1 tsp đường\r\n– 1/2 tsp tiêu bột\r\n– 30 lá lốt to\r\nTrang trí, ăn kèm\r\n– Lạc rang giã vỡ\r\n– Bánh tráng (tùy thích)\r\n– Xà lách, rau thơm (tùy thích)\r\n– Chuối chát, xoài chua (tùy thích)\r\nXốt chấm me đậu phộng:\r\n– 50g cốt me\r\n– 4 Tbsp đường vàng\r\n– 4 Tbsp nước mắm\r\n– 2 Tbsp tép/ tôm khô\r\n– 1 cup nước\r\n– 2 củ hành tím băm\r\n– 1 củ hành tím xắt lát\r\n– 1 Tbsp ớt sừng băm\r\n– Lạc rang giã vụn (ít nhiều tùy thích)\r\nCách làm mình đã chia sẻ trong từng ảnh.\r\nBạn nào muốn nghe chị Admin “Vua Tiếng Việt” vừa đọc rap siêu líu lưỡi, vừa nấu ăn ngon lành cành đào thì ghé ngay kênh Tóp Tóp của Yêu Bếp nhé thuỳ link đây: https://vt.tiktok.com/ZSRbcCx5U/\r\nBật mí là bạn hãy tập đọc rap dần đi là vừa, sắp có một hoạt động SIÊU THÚ VỊ liên quan đến vi déo hài hước độc lạ này đó nha ❤",
                        Published = true,
                        UrlSlug = "Post26",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post26.jpg"
                    },
                    new Post()
                    {
                        Id = 27,
                        Title = "MÓN NGON CUỐI TUẦN DỄ LÀM: THỊT KHO MĂNG NỨA",
                        ShortDescription = "MÓN NGON CUỐI TUẦN DỄ LÀM: THỊT KHO MĂNG NỨA Trời lạnh rồi, kho thịt thôi! Mùa này đang có măng nứa tươi rất ngon và rất rẻ. 20 cành 1 kí măng tươi kho được một nồi thịt ngon…",
                        PostContent = "MÓN NGON CUỐI TUẦN DỄ LÀM: THỊT KHO MĂNG NỨA 🌿\r\nTrời lạnh rồi, kho thịt thôi!\r\nMùa này đang có măng nứa tươi rất ngon và rất rẻ. 20 cành 1 kí măng tươi kho được một nồi thịt ngon tuyệt văn vời ngon tơi bời khói lửa ngon thủng nồi trôi rế.\r\nCái kiểu thịt kho măng nứa vừa thơm vừa cay tê, măng giòn tan, thịt mềm rục ăn cùng cơm nóng và dưa chua.\r\nNguyên liệu:\r\nNguyên liệu:\r\n– 300g măng nứa\r\n– 3 Tbsp dấm + 1 Tbsp đường để ngâm măng\r\n– 3 Tbsp đường nấu nước màu\r\n– 500g thịt ba chỉ\r\nGia vị ướp thịt:\r\n– hành khô bằm nhỏ\r\n– 1-2 quả ớt tươi bằm nhỏ\r\n– 1 tsp tiêu tươi/tiêu sọ\r\n– 1 tsp tiêu bột\r\n– mắm, muối vừa ăn tuỳ khẩu vị\r\n– 1 Tbsp đường\r\n",
                        Published = true,
                        UrlSlug = "Post27",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1,
                        Image = "post27.jpg"
                    },
                    new Post()
                    {
                        Id = 28,
                        Title = "BÍ KÍP BÓC BƯỞI CỰC NHANH CỰC DỄ, SẠCH HẾT GÂN XƠ",
                        ShortDescription = "BÍ KÍP BÓC BƯỞI CỰC NHANH CỰC DỄ, SẠCH HẾT GÂN XƠ Bà bảo bé Bi, bà bổ bưởi, bé Bi bóc. Bé Bi bảo, bé biết bóc bưởi 3 bước bất bại!! Thế là mình học lỏm bé Bi…",
                        PostContent = "Đảm bảo cực NHANH – DỄ – SẠCH hết gân xơ, không bị he đắng tí nào, bóc cả chục quả liền một lúc cũng chẳng xi nhê.\r\nMùa này hanh hao da dẻ nứt nẻ, ngoài uống đủ nước thì các bạn nhớ bổ sung vitamin nhé. Bưởi chính là loại hoa quả cực giàu vitamin C đấy, ăn tươi hoặc ép nước đều cực kì ngon lành và thanh mát.\r\nChỉ cần đúng một cây “gậy như ý” mà nhà nào cũng có là hô biến quả bưởi to đùng thành từng múi bưởi mọng nước, chắc nịch, chấm miếng muối tôm ngon đỉnh của chóp. Bóc sạch sẽ, đẹp thế này đố ai từ chối luôn, các bé cũng hết cớ lười ăn hoa quả nhé!\r\nĐây cũng là mẹo vặt rất hữu ích cho các bạn làm pha chế hay mở quầy nước ép đấy.\r\nMẹo bóc bưởi 3 bước bất bại, mình hướng dẫn trong từng ảnh.\r\nĐặc biệt, bạn nào cung Xử Nữ thì phải xem ngay vi déo https://vt.tiktok.com/ZSRWcKTDc/ để thấy được cái sự mãn nhãn của màn bóc bưởi này nha =)))\r\nNếu bạn chưa biết thì bưởi là loại quả siêu giàu vitamin C và các khoáng chất. Thời tiết hanh hao thế này ăn bưởi là chuẩn luôn, vừa tăng đề kháng lại đẹp da nha 😃\r\nAi lười chứ với mẹo bóc bưởi này của mình thì cả chục quả cũng vẫn đơn giản.\r\nChỉ cần có bảo bối “gậy như ý” – chính là que tăm, thứ mà nhà ai cũng có.\r\nÚm ba la hết sạch gân xơ trong phút mốt luô",
                        Published = true,
                        UrlSlug = "Post28",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2,
                        Image = "post28.jpg"
                    },
                    new Post()
                    {
                        Id = 29,
                        Title = "[Kỹ năng dao bếp] ĐẠI HỒNG CÚC ĐẬU HŨ/ TÚ CẦU ĐẬU HŨ",
                        ShortDescription = "[Kỹ năng dao bếp] ĐẠI HỒNG CÚC ĐẬU HŨ/ TÚ CẦU ĐẬU HŨ Có ai xem phim Mộng Hoa Lục và trầm trồ khi thấy Tam Nương tỉa đậu hũ thành bông hoa cúc khiến các đầu bếp khác phải…",
                        PostContent = "Bông cúc đậu hũ này sẽ được thưởng thức trong nước dùng bắt bửu từ các loại nguyên liệu thượng hạng như bào ngư, vi cá, tôm hùm, thịt càng cua bể hoặc các loại nấm quý.\r\nMón canh thượng hạng và đẹp mắt này thường chỉ thấy trong các nhà hàng cực kì đẳng cấp của ẩm thực Trung Hoa, do không có nhiều đầu bếp thực hiện được tuyệt kĩ này.\r\nViệc biến một nguyên liệu thông dụng, bình thường thành một thứ mỹ thực chính là dụng công để khiến nó trở nên khác lạ, mới mẻ và đem lại trải nghiệm tuyệt bích của các giác quan.\r\nĐầu tiên là đẹp mắt. Không phải ai cũng làm được.\r\nTiếp theo là việc khi nếm một thìa canh với những sợi đậu hũ non mướt mịn như tơ, nó chính là trải nghiệm hoàn toàn bay bổng, hứng khởi và khác biệt việc bạn xúc một miếng đậu hũ thông thường. Đó là sự tinh tế của trải nghiệm ẩm thực.\r\n…\r\nVới mình, “yêu bếp” chính là một hành trình chinh phục. Chinh phục các kĩ năng làm bếp cũng là chinh phục chính bản thân mình.\r\nKhoảng 1-2 tuần trước, khi bộ phim Mộng Hoa Lục đang rất hot, các bạn Admin Yêu Bếp ở Esheep Kitchen Studio có tám chuyện về phần trình diễn tỉa hồng cúc đậu phụ này của Tam Nương trong phim.\r\nMình buột miệng bảo: À món này, chị làm được.\r\nKhông ai tin. Các em bảo mình là ôi chị ơi, người ta mất bao nhiêu năm, rèn luyện ngày đêm để làm được ra đại hồng cúc ở mức độ đúng là đại hồng cúc. Chứ không phải như mấy video cắt ghép giải trí trên YT hoặc ở mức độ sơ đẳng hoa thì méo cánh thì to đâu.\r\nTuy nhiên, với mình thì “giới hạn của người khác không nhất thiết là giới hạn của mình”.\r\nMình chưa bao giờ “bỗng dưng khoe tài”, nên cũng chưa bao giờ thể hiện món này trước mặt các em.\r\nHôm ấy, vui lên, mình liền bảo các em mua đậu về đây, chị làm cho.\r\nVà đó là lần đầu tiên các em ấy được nhìn thấy một đoá đại hồng cúc đậu phụ ngoài đời thật.\r\nBạn có biết, mình đã mất bao nhiêu lâu để đạt tới tuyệt kĩ đao pháp này trong hành trình yêu bếp của mình không?\r\nBạn có muốn mình hướng dẫn từng bước cánh luyện tập kĩ năng dao bếp với đậu hũ không?\r\nBạn có muốn thử thách mình ở các cấp độ cao hơn, khó hơn của món này, hoặc muốn mình chia sẻ kĩ hơn không? Cùng comment nhé!",
                        Published = true,
                        UrlSlug = "Post2",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2,
                        Image = "post2.jpg"
                    },
                    new Post()
                    {
                        Id = 30,
                        Title = "MẸO PHA NƯỚC CHẤM ỐC & CÁCH LUỘC ỐC SẠCH TINH BÉO GIÒN",
                        ShortDescription = "MẸO PHA NƯỚC CHẤM ỐC & CÁCH LUỘC ỐC SẠCH TINH BÉO GIÒN Không có nước chấm ốc kiểu này, ốc có cũng như không… Đôi khi lòng buồn đến nỗi, chỉ biết nương tựa vào bát nước chấm cay…",
                        PostContent = "MẸO PHA NƯỚC CHẤM ỐC & CÁCH LUỘC ỐC SẠCH TINH BÉO GIÒN 🌿\r\nKhông có nước chấm ốc kiểu này, ốc có cũng như không… Đôi khi lòng buồn đến nỗi, chỉ biết nương tựa vào bát nước chấm cay xè, chua cay mặn ngọt sóng sánh chấm đẫm mấy con ốc béo mẫm giòn sựt này đây.\r\nNgày Hà Nội trở gió, em xin kể lại bí kíp pha nước chấm ốc luộc kiểu Hà Nội của mẹ em. Mẹ em bảo, luộc ốc ngon mà không pha được nước chấm, thì có như không có mà thôi. Tiện đây mẹ em bảo luôn cách ngâm ốc nhả nhớt cực nhanh cứ sạch tinh ra béo mẫm.\r\nỪ thì thôi có gì đâu. Cuộc đời khi có khi không.\r\nNhững thứ từng nắm trong tay, tưởng mãi mãi nhưng phút như cát bụi lọt qua kẽ tay.\r\nChỉ còn lại đây nồi ốc luộc bỏng rãy nhể gai chanh gai bưởi thơm nức chấm nước chấm ốc best gia truyền của mẹ em.\r\nSau đây em xin được trình bày nhạc phẩm “Có như không có” qua bản cover diễm lệ thơm mùi nước chấm ốc.\r\nChi tiết mẹo nhỏ & cách làm tại đây:\r\nhttps://vt.tiktok.com/ZSdN8Q3j3/\r\nCòn đâu thì ngắm ảnh thêm cho thấm.",
                        Published = true,
                        UrlSlug = "Post30",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2,
                        Image = "post30.jpg"
                    },
                    new Post()
                    {
                        Id = 31,
                        Title = "HỌC CÁCH CẮT DỨA (THƠM) 2 KIỂU CỰC DỄ",
                        ShortDescription = "HỌC CÁCH CẮT DỨA (THƠM) 2 KIỂU CỰC DỄ Đang là những ngày cuối tháng 5, dứa mật chín rộ vào mùa cực rẻ. Tranh thủ làm thật nhiều món ngon từ dứa, nhưng không phải ai cũng biết cách…",
                        PostContent = "Tranh thủ làm thật nhiều món ngon từ dứa, nhưng không phải ai cũng biết cách tự gọt, bổ dứa tại nhà sao cho ngon đẹp.\r\nBiết cách tự gọt, bổ dứa để gọt tại nhà thì vừa vệ sinh sạch sẽ hơn, vừa trữ dứa nguyên quả được lâu hơn dứa đã gọt, lại còn bớt được rác thải nilon dùng một lần từ hàng dứa khi bạn mua dứa đã gọt đó.\r\n2 cách cắt theo 2 hìnhcơ bản nhất nhiều người cần chính là:\r\n– Cắt dứa hình que đều đẹp không gãy để ăn các món cuốn, trộn gỏi, salad… mà không phí phạm phải bỏ đi nhiều phần dứa thừa thẹo.\r\n– Cắt dứa hình hoa hướng dương đẹp đều cánh, không gãy để ướp lạnh ăn tươi, lắc muối ớt hoặc sấy khô trữ lâu để hãm trà, pha nước.\r\nNay, mình hướng dẫn cả cách bổ dứa rất dễ, sạch sẽ, tay không cần chạm vào thịt quả khi bổ. Và 2 cách cắt dứa theo 2 hình cơ bản trên nha. Hãy chọn quả dứa chín vàng đều, mắt nở to đều, các đường mắt xếp đều đặn sẽ ngon & dễ cắt hơn nha.\r\nHướng dẫn chi tiết trong từng hình.\r\nBạn chỉ cần 1 con dao thật sắc nhé.\r\nLàm thử nào:\r\nĐầu tiên là cách cắt thơm (dứa) hình que để ăn đồ cuốn khiến bao người đau đầu. Nhiều bạn mãi cũng cứ gãy nát và phải bỏ đi rất nhiều phần vụn không dùng được rất uổng. Nay bạn có thể thử cách này nhá! Cách làm chi tiết trong từng ảnh phía sau của bài nha!\r\nCách 2 là cách bổ dứa và lấy mắt sao cho “bông hoa dứa” nó đẹp đều tròn cánh không bị gãy cánh nha! Cách này lại hay bị mọi người cho là “gọt ngược” nè!\r\nNhưng đừng sợ! “Think outside the box”, nghĩ khác đi, làm khác đi, không sợ chê cười đôi khi lại có thể đem lại kết quả cực kì khác biệt và tốt đẹp đó!",
                        Published = true,
                        UrlSlug = "Post31",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2,
                        Image = "post31.jpg"
                    },
                    new Post()
                    {
                        Id = 32,
                        Title = "MẸO HAY NGÀY TẾT",
                        ShortDescription = "Cọ sạch bay nồi tráng men ám vàng và cặn đen bẩn BẰNG DẦU ĂN THỪA SAU KHI CHIÊN 🤩Đừng vứt bỏ dầu thừa mà phí của, cũng đừng chiên đi chiên lại mà không tốt cho sức khoẻ nhé…",
                        PostContent = "Đừng vứt bỏ dầu thừa mà phí của, cũng đừng chiên đi chiên lại mà không tốt cho sức khoẻ nhé các bạn!\r\nMình ngớ ngẩn đun vỏ cam bằng cái nồi trắng muốt! Đun được mẻ nước xông nhà với lau nhà xong thì quả nồi vàng khè và cáu đen lại không thể chà được!!!\r\nVà mình thử nghiệm ngay: lôi dầu ăn thừa từ mấy tuần trước còn giữ lại ra, lọc lại cho sạch bằng giấy ăn cho đến khi trong veo. Rồi mình dùng 1 ít giấy ăn nhúng vào dầu đó và cọ thử!!\r\nÔi mẹ ơi không tưởng được!!\r\nAmazing!!!\r\nSau khi sạch xong thì mình dùng nước enzim bồ hòn tự ngâm để làm sạch dầu thừa còn bám trong nồi là xong!\r\nHa ha ha chả cần 1 tý hoá chất nào luôn! Sạch bong kin kít!!\r\nTrong khi nồi inox của mình hôm trước đun nước vỏ cam bị bám cáu đen dớp dính như này cọ đủ kiểu không hết sạch được!!\r\nTuyệt quá nên phải báo cáo các bạn ngay!\r\nCảm ơn Trà My với mẹo hay tuyệt!",
                        Published = true,
                        UrlSlug = "Post32",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2,
                        Image = "post32.jpg"
                    }
                );
            modelBuilder.Entity<Tag>().HasData(
                    new Tag()
                    {
                        Id = 1,
                        Name = "BÁNH MÌ"

                    },
                    new Tag()
                    {
                        Id = 2,
                        Name = "BÁNH NGỌT"

                    },
                    new Tag()
                    {
                        Id = 3,
                        Name = "BREAKFAST"

                    },
                    new Tag()
                    {
                        Id = 4,
                        Name = "ĐỒ UỐNG"

                    },
                    new Tag()
                    {
                        Id = 5,
                        Name = "KHAI VỊ"

                    },
                    new Tag()
                    {
                        Id = 6,
                        Name = "MÓN CHÍNH"

                    },
                    new Tag()
                    {
                        Id = 7,
                        Name = "MÓN PHỤ"

                    },
                    new Tag()
                    {
                        Id = 8,
                        Name = "MÓN TRÁNG MIỆNG"

                    },
                    new Tag()
                    {
                        Id = 9,
                        Name = "MÓN VIỆT NAM"

                    },
                    new Tag()
                    {
                        Id = 10,
                        Name = "CÔNG THỨC"

                    },
                    new Tag()
                    {
                        Id = 11,
                        Name = "MẸO VẶT"

                    }
                );
            modelBuilder.Entity<PostTagMap>().HasData(
                new PostTagMap() { PostId = 1, TagId = 1 },
                new PostTagMap() { PostId = 1, TagId = 3 },
                new PostTagMap() { PostId = 1, TagId = 10 },
                new PostTagMap() { PostId = 2, TagId = 1 },
                new PostTagMap() { PostId = 2, TagId = 10 },
                new PostTagMap() { PostId = 3, TagId = 1 },
                new PostTagMap() { PostId = 3, TagId = 10 },
                new PostTagMap() { PostId = 4, TagId = 2 },
                new PostTagMap() { PostId = 4, TagId = 10 },
                new PostTagMap() { PostId = 5, TagId = 2 },
                new PostTagMap() { PostId = 5, TagId = 10 },
                new PostTagMap() { PostId = 6, TagId = 2 },
                new PostTagMap() { PostId = 6, TagId = 8 },
                new PostTagMap() { PostId = 6, TagId = 10 },
                new PostTagMap() { PostId = 7, TagId = 3 },
                new PostTagMap() { PostId = 7, TagId = 10 },
                new PostTagMap() { PostId = 8, TagId = 3 },
                new PostTagMap() { PostId = 8, TagId = 9 },
                new PostTagMap() { PostId = 8, TagId = 10 },
                new PostTagMap() { PostId = 9, TagId = 3 },
                new PostTagMap() { PostId = 9, TagId = 6 },
                new PostTagMap() { PostId = 9, TagId = 10 },
                new PostTagMap() { PostId = 10, TagId = 4 },
                new PostTagMap() { PostId = 10, TagId = 8 },
                new PostTagMap() { PostId = 10, TagId = 10 },
                new PostTagMap() { PostId = 11, TagId = 4 },
                new PostTagMap() { PostId = 11, TagId = 10 },
                new PostTagMap() { PostId = 12, TagId = 4 },
                new PostTagMap() { PostId = 12, TagId = 10 },
                new PostTagMap() { PostId = 13, TagId = 5 },
                new PostTagMap() { PostId = 13, TagId = 10 },
                new PostTagMap() { PostId = 14, TagId = 5 },
                new PostTagMap() { PostId = 14, TagId = 10 },
                new PostTagMap() { PostId = 15, TagId = 5 },
                new PostTagMap() { PostId = 15, TagId = 7 },
                new PostTagMap() { PostId = 16, TagId = 6 },
                new PostTagMap() { PostId = 16, TagId = 10 },
                new PostTagMap() { PostId = 17, TagId = 6 },
                new PostTagMap() { PostId = 17, TagId = 10 },
                new PostTagMap() { PostId = 18, TagId = 6 },
                new PostTagMap() { PostId = 18, TagId = 9 },
                new PostTagMap() { PostId = 19, TagId = 7 },
                new PostTagMap() { PostId = 19, TagId = 10 },
                new PostTagMap() { PostId = 20, TagId = 7 },
                new PostTagMap() { PostId = 20, TagId = 10 },
                new PostTagMap() { PostId = 21, TagId = 7 },
                new PostTagMap() { PostId = 21, TagId = 10 },
                new PostTagMap() { PostId = 22, TagId = 8 },
                new PostTagMap() { PostId = 22, TagId = 10 },
                new PostTagMap() { PostId = 22, TagId = 11 },
                new PostTagMap() { PostId = 23, TagId = 11 },
                new PostTagMap() { PostId = 23, TagId = 8 },
                new PostTagMap() { PostId = 23, TagId = 10 },
                new PostTagMap() { PostId = 24, TagId = 8 },
                new PostTagMap() { PostId = 24, TagId = 9 },
                new PostTagMap() { PostId = 25, TagId = 9 },
                new PostTagMap() { PostId = 25, TagId = 10 },
                new PostTagMap() { PostId = 26, TagId = 6 },
                new PostTagMap() { PostId = 26, TagId = 9 },
                new PostTagMap() { PostId = 26, TagId = 10 },
                new PostTagMap() { PostId = 27, TagId = 6 },
                new PostTagMap() { PostId = 27, TagId = 9 },
                new PostTagMap() { PostId = 27, TagId = 10 },
                new PostTagMap() { PostId = 28, TagId = 11 },
                new PostTagMap() { PostId = 29, TagId = 11 },
                new PostTagMap() { PostId = 30, TagId = 9 },
                new PostTagMap() { PostId = 30, TagId = 11 },
                new PostTagMap() { PostId = 31, TagId = 11 },
                new PostTagMap() { PostId = 32, TagId = 11 });
        }
    }
}