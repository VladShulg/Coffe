var AddSlide = /** @class */ (function () {
    function AddSlide() {
    }
    AddSlide.AddSlide = function () {
        var eventName = document.getElementById("name").value;
        var eventImgSrc = document.getElementById("imgsrc").value;
        var data = {
            Name: eventName,
            ImgSrc: eventImgSrc,
        };
        CoffeeAppCore.Requester.SendAjaxPost("/Home/AddSlideApi", data, function () {
            alert("Слайд добавлен");
            window.location.assign("/Home/Admin");
        }, function () {
            alert("Не удалось добавить слайд");
        });
    };
    AddSlide.SetHandler = function () {
        document.getElementById("add-slide-btn").addEventListener("click", function () { return AddSlide.AddSlide(); });
    };
    return AddSlide;
}());
AddSlide.SetHandler();
