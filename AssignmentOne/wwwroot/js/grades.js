function calcGrade() {

    /* Getting inputs and dividing by zero then weighing them appropriately and determining letter grade*/
    var assignment = $('#hw').val() / 100;
    var group = $('#groupProject').val() / 100;
    var quiz = $('#quiz').val() / 100;
    var exam = $('#exam').val() / 100;
    var intex = $('#intex').val() / 100;
    var letterGrade;

    assignment = assignment * (2000 * .5);
    group = group * (2000 * .1);
    quiz = quiz * (2000 * .1);
    exam = exam * (2000 * .2);
    intex = intex * (2000 * .1);

    var totalPoints = assignment + group + quiz + exam + intex;
    var gradePct = totalPoints / 2000;
    gradePct = gradePct * 100;

    if (gradePct >= 94) {
        letterGrade = 'A';
    }
    else if (gradePct < 94 && gradePct >= 90) {
        letterGrade = 'A-'
    }
    else if (gradePct < 90 && gradePct >= 87) {
        letterGrade = 'B+'
    }
    else if (gradePct < 87 && gradePct >= 84) {
        letterGrade = 'B'
    }
    else if (gradePct < 84 && gradePct >= 80) {
        letterGrade = 'B-'
    }
    else if (gradePct < 80 && gradePct >= 77) {
        letterGrade = 'C+'
    }
    else if (gradePct < 77 && gradePct >= 74) {
        letterGrade = 'C'
    }
    else if (gradePct < 74 && gradePct >= 70) {
        letterGrade = 'C-'
    }
    else if (gradePct < 70 && gradePct >= 67) {
        letterGrade = 'D+'
    }
    else if (gradePct < 67 && gradePct >= 64) {
        letterGrade = 'D'
    }
    else if (gradePct < 64 && gradePct >= 60) {
        letterGrade = 'D-'
    }
    else  {
        letterGrade = 'E'
    }

    var gradePercent = gradePct.toFixed(2)

    alert('You have a ' + letterGrade + ' with a ' + gradePercent + '%') 

}


