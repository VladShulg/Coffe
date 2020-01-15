class AddSlide{
    static AddSlide() {
        var eventName = (document.getElementById("name") as HTMLInputElement).value;
        var eventImgSrc = (document.getElementById("imgsrc") as HTMLInputElement).value;
        var data = {
            Name: eventName,
            ImgSrc: eventImgSrc,
        };

        CoffeeAppCore.Requester.SendAjaxPost("/Home/AddSlideApi", data,
            () => {
                alert("Слайд добавлен");
                window.location.assign("/Home/Admin")
            },
            () => {
                alert("Не удалось добавить слайд");
            });
    }

    static SetHandler() {
        document.getElementById("add-slide-btn").addEventListener("click", () => AddSlide.AddSlide())
    }
}

AddSlide.SetHandler();