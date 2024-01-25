jQuery(document).ready(function () {
    console.log("hello boys");
    $("#viewchart").on('click', function () {
        $(".viewchartsection").css("display", "block");
        $(".viewgroupsection").css("display", "none");
    })

    $("#viewgroups").on('click', function () {
        $(".viewchartsection").css("display", "none");
        $(".viewgroupsection").css("display", "block");
    })

    var data = {
        labels: ['Class A', 'Class B', 'Class C', 'Class D'],
        datasets: [{
            label: 'Count of Claims',
            data: [20, 30, 15, 25],
            backgroundColor: 'rgba(54, 162, 235, 0.5)' // Specify the bar color
        }]
    };

    var ctx = document.getElementById('myChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: data
    });

    var dataTwo = {
        labels: ['January', 'February', 'March', 'April', 'May'],
        datasets: [
            {
                label: 'Data Set 1',
                data: [10, 15, 20, 18, 25],
                borderColor: 'rgba(54, 162, 235, 1)',
                fill: false
            },
            {
                label: 'Data Set 2',
                data: [5, 8, 12, 10, 16],
                borderColor: 'rgba(255, 99, 132, 1)',
                fill: false
            }
        ]
    };

    var ctxTwo = document.getElementById('myChartTwo').getContext('2d');
    var myChart = new Chart(ctxTwo, {
        type: 'line',
        data: dataTwo
    });

    var dataThree = {
        labels: ['Category A', 'Category B', 'Category C'],
        datasets: [{
            data: [30, 45, 25],
            backgroundColor: ['rgba(54, 162, 235, 0.5)', 'rgba(255, 99, 132, 0.5)', 'rgba(75, 192, 192, 0.5)']
        }]
    };

    var ctxThree = document.getElementById('myChartThree').getContext('2d');
    var myChart = new Chart(ctxThree, {
        type: 'pie',
        data: dataThree
    });
})
