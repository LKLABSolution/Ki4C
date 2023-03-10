const questions = document.querySelector("#questions");

const QUESTIONS_KEY = "companyBasic";

function readQuestions(items) {
    
    if (items['type'] === "essay") {
        console.log("essay");
        const div = document.createElement("div");
        const h3 = document.createElement("h3");
        const input = document.createElement("input");const hr = document.createElement("hr");

        div.appendChild(h3);
        h3.innerText = items['q1']
        input.setAttribute("class", "essay");
        input.setAttribute("type", "text");
        input.setAttribute("placeholder", "100자 이내");

        div.appendChild(input);
        div.appendChild(hr);
        questions.appendChild(div);

    } else {
        const div = document.createElement("div");
        const h3 = document.createElement("h3");
        const p = document.createElement("p");
        const hr = document.createElement("hr");

        div.appendChild(h3);
        div.appendChild(p);

        h3.innerText = items['q1']
        p.innerText = items['q2']
        div.appendChild(h3);
        div.appendChild(p);
        
        for (i=0; i < items['q3'].length; i++){
            window["input_"+i] = document.createElement("input");
            window["input_"+i].setAttribute("type", "radio");

            window["label_"+i] = document.createElement("label");
            window["label_"+i].innerText = items['q3'][i]

            div.appendChild(window["input_"+i]);
            div.appendChild(window["label_"+i]);
        }

        div.appendChild(hr);
        questions.appendChild(div)
    }
}

// 테스트 데이터
const data = [
    {
        type:"essay",
        q1: "기업명"
    }, 
    {
        type:"multiple",
        q1: "기업구분",
        q2: "귀사의 기업 구분에 해당하는 항목은 무엇입니까?", 
        q3: ["중견기업", "중소기업", "기타"]
    }, {
        type: "multiple",
        q1: "업종구분",
        q2: "귀사의 업종에 해당하는 항목은 무엇입니까?",
        q3: ["기계소재", "전기전자", "화학", "정보통신", "바이오의료", "에너지 자원", "지식서비스"]
    }, {
        type: "multiple",
        q1: "기업규모(종업원수)",
        q2: "귀사의 상시 종업원 수에 해당하는 항목은 무엇입니까?",
        q3: ["19명 이하", "20-99명", "100-249명", "250-499명", "500명-999명", "1,000명 이상"]
    }, {
        type: "multiple",
        q1: "기업매출",
        q2: "귀사의 전년도 매출은 어떠한 수준입니까?",
        q3: ["200억원 미만", "200억원 ~ 400억원 미만", "400억원 ~ 500억원 미만","500억원 ~ 1,500억원 미만",
         "1,500억원 ~ 3,000억원 미만", "3,000억원 ~5,000억원 미만", "5,000억원 이상"]
    }, {
        type: "multiple",
        q1: "기업소재지",
        q2: "귀사의 소재지역(본사기준)에 해당하는 항목은 무엇입니까?",
        q3: ["서울", "부산", "대구", "인천", "광주", "대전", "울산", "세종", "경기", "강원", "충북",
        "충남", "전북", "전남", "경북", "경남", "제주"]
    }

]
localStorage.setItem(QUESTIONS_KEY, JSON.stringify(data));

const savedQuestions = localStorage.getItem(QUESTIONS_KEY);
const parsedQuestions = JSON.parse(savedQuestions);
parsedQuestions.forEach(readQuestions);
