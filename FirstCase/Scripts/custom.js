
   var persons = [
    {
        "name" : "Gökhan Türkmen",
        "tckn" : "29229229229",
        "phone": "05329875544",
        "birthPlace":"Kayseri",
        "sıraNo" : "4"
    },
    {
        "name" : "Fatma Turunç",
        "tckn" : "29229213513",
        "phone": "05448653412",
        "birthPlace":"İstanbul",
        "sıraNo" : "5"
    },
    {
        "name" : "Yalçın Borga",
        "tckn" : "29278913413",
        "phone": "05448798412",
        "birthPlace":"Balıkesir",
        "sıraNo" : "1"
    },
    {
        "name" : "Fatma Turunç",
        "tckn" : "29224523513",
        "phone": "05412353412",
        "birthPlace":"Trabzon",
        "sıraNo" : "3"
    }            
];


var detail = [
    [{
        "name" : "Gökhan Türkmen",
        "tckn" : "29229229229",
        "phone": "05329875544",
        "birthPlace":"Kayseri"
    },
    {
        "name" : "Gökhan Türkmen",
        "tckn" : "29229229229",
        "phone": "05329875544",
        "birthPlace":"Kayseri"
    },
    {
        "name" : "Gökhan Türkmen",
        "tckn" : "29229229229",
        "phone": "05329875544",
        "birthPlace":"Kayseri"
    }]
    ,
    [{
        "name" : "Fatma Turunç",
        "tckn" : "29229213513",
        "phone": "05448653412",
        "birthPlace":"İstanbul"
    }],
    [{
        "name" : "Yalçın Borga",
        "tckn" : "29278913413",
        "phone": "05448798412",
        "birthPlace":"Balıkesir"
    },
    {
        "name" : "Fatma Turunç",
        "tckn" : "29224523513",
        "phone": "05412353412",
        "birthPlace":"Trabzon"
    }],
    [{
        "name" : "Yalçın Borga",
        "tckn" : "29278913413",
        "phone": "05448798412",
        "birthPlace":"Balıkesir"
    },
    {
        "name" : "Fatma Turunç",
        "tckn" : "29224523513",
        "phone": "05412353412",
        "birthPlace":"Trabzon"
    }]


];



$(document).ready(function(){
    
    for(index in persons){$(".container #BodyContent").append(
            "<tr><td><img src='img/arti.png' id=person"+persons.indexOf(persons[index])+" style='width:25px;margin-right:10px'/>"+persons[index].name+"</td><td><a id=TC"+persons.indexOf(persons[index])+">"+persons[index].tckn+"</a></td><td id=PH"+persons.indexOf(persons[index])+"><a>"+persons[index].phone+"</td></tr>"); 
    }

    $("img").click(function(event){

        var elementId = event.target.id.substring(6);
        var imageSource = $("tr td img:eq("+elementId+")").attr("src");
        

        if(imageSource == "img/eksi.png"){
            $("tr td img:eq("+elementId+")").attr("src","img/arti.png");
            $("#personDetail"+elementId).remove();
        }
        else
        {
            $("tr td img:eq("+elementId+")").attr("src","img/eksi.png");
            
            var detailList = detail[elementId];
            var data="";
            
            for(index in detailList)
            { 
                data +="<div>"+detailList[index].name+"</div><div>"+detailList[index].tckn+"</div><div>"+detailList[index].phone+"</div>";
            }

            $("#BodyContent tr:eq("+elementId+")").after("<tr class='customTr' id='personDetail"+elementId+"'><td colspan='3'>"+data+"</td></tr>");
        }
    });

    $(function(){       
            $("a").click(function(event){

            

            var elementId = event.target.id;
            
            if(elementId.substr(0,2)=="TC")
            {
                popUpTemizle();
                var elementId = event.target.id.substr(2);
                
                var personDetail = persons[elementId];

                $("#popPersonAd").append(personDetail.name);
                $("#popPersonTckn").append(personDetail.tckn);
                $("#popPersonSıraNo").append(personDetail.sıraNo);
                $("#popPersonBirthPlace").append(personDetail.birthPlace);

                $("#divPopUp").dialog({
                    title:'Personel Detay',
                    backdrop: 'static',
                    width:450,
                    height:400,
                    modal:true
                });
            }
            else
            {
                $("#divPopUpArama").dialog({
                    title:'Arama',
                    backdrop: 'static',
                    width:450,
                    height:400,
                    modal:true
                });
            }
        })
    });

    var popUpTemizle = function(){
        $("#popPersonAd").empty();
        $("#popPersonTckn").empty();
        $("#popPersonSıraNo").empty();
        $("#popPersonBirthPlace").empty();
    }
});        

