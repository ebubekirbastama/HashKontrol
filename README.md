# HashKontrol

HashKontrol, belirli bir dosyanın bütünlüğünü kontrol etmek için tasarlanmış basit bir C# programıdır. SHA-256 karma kullanarak belirli bir dosyanın hash'ini kontrol eder. Hash'i belirli bir URL'den alınan önceden belirlenmiş bir hash ile karşılaştırır.

## Özellikler

- **Dosya Hash Hesaplama:** Belirtilen bir dosyanın SHA-256 hash'ini hesaplar.
- **Hash Doğrulama:** Hesaplanan hash'i, `https://raw.githubusercontent.com/ebubekirbastama/HashKontrol/main/hash` adresinden alınan önceden belirlenmiş bir hash ile karşılaştırır.
- **Uygulama Kontrolü:** Hash'ler uyuşmazsa uygulamadan çıkar, dosya bütünlüğünü sağlar.

## Kullanım

1. **Kodu İndirin:**
   - Bu depoyu klonlayın veya `hashkontrol.cs` dosyasını indirin.

2. **Kodu Derleyin:**
   - Bir C# IDE veya derleyici kullanarak dosyayı açın ve uygulamayı derleyin.

3. **Uygulamayı Çalıştırın:**
   - Derlenmiş uygulamayı çalıştırın.

4. **Hash Doğrulama:**
   - Uygulama, belirtilen bir dosyanın SHA-256 hash'ini hesaplar.
   - Hesaplanan hash'i `https://raw.githubusercontent.com/ebubekirbastama/HashKontrol/main/hash` adresinden alınan önceden belirlenmiş hash ile karşılaştırır.
   - Hash'ler uyuşmazsa uygulama kapanır, uyuşursa devam eder.

## Bağımlılıklar

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) - Uygun sürümün yüklü olduğundan emin olun.

## Katkıda Bulunma

Bu projeye katkıda bulunmak istiyorsanız, depoyu forklayabilir ve pull request gönderebilirsiniz.

## Lisans

Bu proje [MIT License](LICENSE) ile lisanslanmıştır - ayrıntılar için [LICENSE](LICENSE) dosyasına bakın.
