const questions = document.querySelector("#questions");
const answer = document.querySelector("#answer");
const prev = document.querySelector("#prevButton");
const next = document.querySelector("#nextButton");
const submit = document.querySelector("#submitButton");
const QUESTIONS_KEY = "selfDiagnosis";
const HIDDEN = "hidden"


function readQuestions(items, idx) { 
    questions.innerHTML = "";
    answer.innerHTML = "";

    const div_q = document.createElement("div");
    const h3 = document.createElement("h3");
    const h4 = document.createElement("h4");
    const h2 = document.createElement("h2");
    const p = document.createElement("p");

    div_q.appendChild(h3);
    div_q.appendChild(h4);
    div_q.appendChild(h2);
    div_q.appendChild(p);

    h3.innerText = items['q1']
    h4.innerText = items['q2']
    h2.innerText = items['q3']
    p.innerText = items['q4']
    questions.appendChild(div_q);

    const div_a = document.createElement("div");

    for (i=0; i <  items['a'].length; i++){
        window["div_"+i] = document.createElement("div");
        window["div_"+i].setAttribute("class", "multiple");
        window["div_"+i].innerText = items['a'][i];

        div_a.appendChild(window["div_"+i]);
    }

    answer.appendChild(div_a);

    if (idx > (parsedQuestions.length - 2)) {
        next.classList.add(HIDDEN);
        submit.classList.remove(HIDDEN);
    } else if (idx !== 0 && idx < parsedQuestions.length) {
        prev.classList.remove(HIDDEN);
    } else if (idx === 0) {
        prev.classList.add(HIDDEN);
    }

    prev.onclick = function() {
        if (idx === parsedQuestions.length - 1) {
            submit.classList.add(HIDDEN);
            next.classList.remove(HIDDEN);
        }
        readQuestions(parsedQuestions[idx-1], idx-1);
    };
    next.onclick = function() {
        readQuestions(parsedQuestions[idx+1], idx+1);
    };

}

// 테스트 데이터
const data = [
    {
        q1: "Customer Understanding",
        q2: "고객경험/가치의 업무연계", 
        q3: "우리 회사가 제공하는 제품/서비스를 사용/소비하는 과정에서 발생하는 고객*의 이슈, 문의사항, 만족도 등을 실시간 데이터로 취합하여 모니터링하고 대응하고 있습니까?",
        q4: "*고객: B2B 기업의 경우 기업고객, B2C기업의 경우 최종소비자를 의미함",
        a: ["고객의 이슈, 문의사항, 만족도 등을 인지하지 못함",
            "고객의 이슈, 문의사항, 만족도 등에 대한 일부 데이터를 취합함",
            "고객의 이슈, 문의사항, 만족도 등에 대한 데이터를 취합하여 관리하고, 업무 수행시 참조하는 수준임",
            "고객의 이슈, 문의사항, 만족도 등에 대한 데이터를 주기적 통합 관리/모니터링하여 업무실행에 반영함",
            " 고객의 이슈, 문의사항, 만족도 등에 대하여 실시간 데이터 기반으로 통합 관리/모니터링/대응 조치하여 지속적으로 업무를 개선함"]
    }, {
        q1: "Customer Understanding",
        q2: "고객 채널/데이터 통합관리", 
        q3: "우리 회사는 고객과 거래/협력/소통을 하기 위하여 전통적인 방식(대면 방문, 유선 통화, 우편, FAX 등)과 디지털 기술이 반영된 방식(E-mail, SNS, 화상회의, 모바일앱 등)을 동시에 활용하여 고객 데이터를 실시간 통합하여 내부업무 및 고객대응을 하고 있습니까?",
        q4: "",
        a: ["전통적인 방식의 단일 채널 운영, 고객 데이터를 별도 관리 안함",
            "전통적인 방식과 디지털 활용 방식의 다양한 채널을 각각 운영 중이며, 각 채널별로 고객 데이터를 관리함",
            "전통적인 방식과 디지털 활용 방식의 다양한 채널을 각각 운영중이며, 채널간 고객 데이터를 공유함",
            "다양한 채널 중 일부 연계하여 운영하고, 고객 데이터를 통합 관리함",
            "다양한 채널을 통합 운영하고, 고객 데이터를 실시간으로 통합 관리함"]
    }, {
        q1: "Strategy & Leadership",
        q2: "디지털 전략과 투자 연계", 
        q3: "우리 회사는 AI, Blockchain, Cloud 등 디지털 기술을 활용하여 사업 전반을 혁신하는 디지털 전략을 수립하여 경영/투자에 반영하고 있습니까?",
        q4: "",
        a: ["디지털 전략이 없음",
            "디지털 전략을 정의했으나, 이를 경영/투자에 반영하지 않음",
            "디지털 전략을 정의하고, 전사 차원의 경영/투자에 반영함",
            "디지털 전략을 정의하고, 전사/사업부 차원의 경영/투자에 반영함",
            "디지털 전략을 정의하고, 조직 전반의 경영/투자 의사결정 기준으로 활용함"]
    }, {
        q1: "Strategy & Leadership",
        q2: "디지털 전환(DT) 과제 기획 및 투자", 
        q3: "우리 회사는 전사적인 차원에서 고객사, 협력업체까지를 포함하는 디지털 전환(DT)과제*를 기획하고, 체계적으로 투자를 실행하고 있습니까?",
        q4: "디지털 전환(DT, Digital Transformation) 과제: 디지털 기술을 제품/서비스 및 업무 프로세스에 적용하는 과제",
        a: ["디지털 전환(DT) 과제에 대한 기획/투자가 없음",
            "디지털 기술 검증을 위한 소규모 투자, 또는 관련 프로젝트 발생시 제한적으로 투자함",
            "전사 전략과 연계하여 디지털 전환(DT) 과제를 기획/투자함",
            "전사/사업부 전략과 연계하여 디지털 전환(DT) 과제를 기획/투자함",
            "전사/사업부 전략 연계 및 대내외 협업까지 포함하는 디지털 전환(DT) 과제를 기획/투자함"]
    }, {
        q1: "People, Organization & Culture",
        q2: "디지털 전환(DT) 경험 기반 학습문화", 
        q3: "우리 회사는 디지털 전환(DT)과 관련하여 새로운 시도를 하도록 장려 및 지원*하고 실패로부터 학습하는 기업문화를 가지고 있습니까?",
        q4: "예: DT 신규사업 인큐베이팅 지원, Lesson Learned 세미나",
        a: ["디지털 전환(DT)을 위한 시도가 없음",
            "디지털 전환(DT)을 위한 시도가 없음",
            "디지털 전환(DT)을 시도하고 있으나, 새로운 시도에 대한 지원과 성공/실패 사례에 대한 학습은 미흠함",
            "디지털 전환(DT)을 추진하고, 새로운 시도에 대한 지원과 성공/실패 사례 학습을 공식적/체계적으로 수행함",
            "디지털 전환(DT)이 활성화되고, 새로운 시도에 대한 지원과 성공/실패 사례에 대한 학습이 내재화되어 조직 문화로 정착됨"]
    }

]

localStorage.setItem(QUESTIONS_KEY, JSON.stringify(data));

const savedQuestions = localStorage.getItem(QUESTIONS_KEY);
const parsedQuestions = JSON.parse(savedQuestions);

readQuestions(parsedQuestions[0], 0);
