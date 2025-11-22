// Attendance page scripts
function toggleAttendance(checkbox, studentId) {
    const status = checkbox.checked;
    console.log(`Student ID ${studentId} attendance: ${status}`);
    // TODO: send AJAX to backend to mark attendance
}

function markAllPresent(courseId) {
    const checkboxes = document.querySelectorAll(".attendance-checkbox");
    checkboxes.forEach(cb => cb.checked = true);
    console.log(`All students marked present for course ${courseId}`);
}
